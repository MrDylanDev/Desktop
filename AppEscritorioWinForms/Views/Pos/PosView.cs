using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>
    /// Punto de venta (migración 1:1 de PosView.xaml de WPF).
    /// Todo el diseño está en PosView.Designer.cs y se edita en el diseñador; aquí solo va la lógica.
    /// </summary>
    public partial class PosView : UserControl
    {
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");

        private readonly List<Product> _products = new List<Product>();
        private BindingList<OrderLine> _ticket;
        private string _table = TicketStore.NoTable;
        private decimal _taxRate = 0.08m;
        private bool _loadingTax;

        public PosView()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            LoadProducts();
            cmbCategory.SelectedIndex = 0;
            _ticket = TicketStore.GetTicketFor(_table);
            ReloadTax();
            SetupTipoPedido();
            RenderProducts();
            RefreshTicket();
        }

        // ===================== API pública (la usa ShellForm) =====================

        /// <summary>Abre el ticket de una mesa (desde Mesas y Salón).</summary>
        public void SetMesa(string mesa)
        {
            _table = string.IsNullOrWhiteSpace(mesa) ? TicketStore.NoTable : mesa;
            lblMesa.Text = _table;
            _ticket = TicketStore.GetTicketFor(_table);
            if (cmbTipo.Items.Count > 0) cmbTipo.SelectedIndex = 0;
            RefreshTicket();
            UpdateDomicilio();
        }

        /// <summary>Aplica el impuesto por defecto guardado en Configuración (tax.dat).</summary>
        public void ReloadTax()
        {
            int p = LocalSettings.LoadTaxPercent();
            _loadingTax = true;
            if (p == 27 && cmbTax.Items.Count == 3) cmbTax.Items.Add("INC+IVA — 27%");
            cmbTax.SelectedIndex = p == 0 ? 0 : p == 19 ? 2 : p == 27 ? 3 : 1;
            _loadingTax = false;
            _taxRate = p / 100m;
            SetupTipoPedido();
            RefreshTotals();
        }

        // ===================== Productos =====================

        private void LoadProducts()
        {
            _products.Add(new Product("Pizza Napolitana Familiar", "Pizzas y pastas", 14500));
            _products.Add(new Product("Bife de Chorizo 400g", "Carnes y parrilla", 22000));
            _products.Add(new Product("Hamburguesa Doble Queso", "Hamburguesas", 12000));
            _products.Add(new Product("Cerveza Tirada IPA", "Bebidas", 5000));
            _products.Add(new Product("Limonada Menta y Jengibre", "Bebidas", 4500));
            _products.Add(new Product("Ensalada César con Pollo", "Carnes y parrilla", 9500));
            _products.Add(new Product("Tiramisú Casero", "Postres y café", 6000));
            _products.Add(new Product("Ravioles 4 Quesos", "Pizzas y pastas", 13500));
        }

        private void RenderProducts()
        {
            string text = (txtSearch.Text ?? string.Empty).Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "Todos";

            flowProducts.SuspendLayout();
            foreach (Control c in flowProducts.Controls.Cast<Control>().ToList()) c.Dispose();
            flowProducts.Controls.Clear();

            foreach (var p in _products.Where(p =>
                         (category == "Todos" || p.Category == category) &&
                         (text.Length == 0 || p.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)))
            {
                var tile = new ProductTile();
                tile.SetProduct(p);
                tile.ProductClicked += ProductTile_ProductClicked;
                flowProducts.Controls.Add(tile);
            }
            flowProducts.ResumeLayout(true);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => RenderProducts();

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e) => RenderProducts();

        private void ProductTile_ProductClicked(object sender, EventArgs e)
        {
            var product = (sender as ProductTile)?.Product;
            if (product == null) return;
            var line = _ticket.FirstOrDefault(x => x.Product.Name == product.Name && string.IsNullOrEmpty(x.Notes));
            if (line == null) _ticket.Add(new OrderLine(product));
            else line.Quantity++;
            RefreshTicket();
        }

        // ===================== Ticket =====================

        private void RefreshTicket()
        {
            if (_ticket == null) _ticket = TicketStore.GetTicketFor(_table);

            flowTicket.SuspendLayout();
            foreach (var item in flowTicket.Controls.OfType<TicketLineItem>().ToList())
            {
                flowTicket.Controls.Remove(item);
                item.Dispose();
            }

            int width = TicketItemWidth();
            foreach (var line in _ticket)
            {
                var item = new TicketLineItem { Width = width };
                item.SetLine(line);
                item.PlusClicked += (s, e) => { line.Quantity++; RefreshTicket(); };
                item.MinusClicked += (s, e) => { line.Quantity--; if (line.Quantity <= 0) _ticket.Remove(line); RefreshTicket(); };
                item.RemoveClicked += (s, e) => { _ticket.Remove(line); RefreshTicket(); };
                item.NoteClicked += (s, e) => EditNote(line);
                flowTicket.Controls.Add(item);
            }
            lblEmpty.Visible = _ticket.Count == 0;
            lblEmpty.Width = width;
            flowTicket.ResumeLayout(true);

            RefreshTotals();
            TicketStore.NotifyChanged();
        }

        private void RefreshTotals()
        {
            decimal subtotal = _ticket?.Sum(x => x.LineTotal) ?? 0m;
            decimal tax = subtotal * _taxRate;
            lblSubtotal.Text = Money(subtotal);
            lblTaxLabel.Text = "Impuesto (" + (_taxRate * 100).ToString("0") + "%)";
            lblTax.Text = Money(tax);
            lblTotal.Text = Money(subtotal + tax);
            btnCobrar.Enabled = _ticket != null && _ticket.Count > 0;
            btnVaciar.Enabled = btnCobrar.Enabled;
        }

        private int TicketItemWidth()
        {
            // Se reserva siempre el ancho de la barra vertical: así nunca aparece la horizontal.
            int width = flowTicket.ClientSize.Width;
            if (!flowTicket.VerticalScroll.Visible) width -= SystemInformation.VerticalScrollBarWidth;
            return Math.Max(200, width - 2);
        }

        private void FlowTicket_Resize(object sender, EventArgs e)
        {
            int width = TicketItemWidth();
            foreach (Control c in flowTicket.Controls) c.Width = width;
        }

        private void EditNote(OrderLine line)
        {
            using (var dialog = new NoteDialog(line.Product.Name, line.Notes))
            {
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    line.Notes = dialog.NoteResult;
                    RefreshTicket();
                }
            }
        }

        private void BtnVaciar_Click(object sender, EventArgs e)
        {
            if (_ticket.Count == 0) return;
            _ticket.Clear();
            RefreshTicket();
        }

        private void CmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loadingTax || cmbTax.SelectedIndex < 0) return;
            switch (cmbTax.SelectedIndex)
            {
                case 0: _taxRate = 0m; break;
                case 2: _taxRate = 0.19m; break;
                case 3: _taxRate = 0.27m; break;
                default: _taxRate = 0.08m; break;
            }
            RefreshTotals();
        }

        // ===================== Tipo de pedido / domicilio =====================

        private bool DeliveryOn => LocalSettings.IsModuleEnabled("delivery");

        private void SetupTipoPedido()
        {
            string previous = cmbTipo.SelectedItem?.ToString();
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Salón (mesa)");
            cmbTipo.Items.Add("Para llevar");
            if (DeliveryOn) cmbTipo.Items.Add("Domicilio propio");
            int idx = previous == null ? 0 : cmbTipo.Items.IndexOf(previous);
            cmbTipo.SelectedIndex = idx < 0 ? 0 : idx;
            UpdateDomicilio();
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e) => UpdateDomicilio();

        private void TxtDomicilio_TextChanged(object sender, EventArgs e) => UpdateDomicilio();

        private string Tipo => cmbTipo.SelectedItem?.ToString() ?? "Salón (mesa)";

        private bool IsDomicilio => Tipo.Contains("Domicilio");

        private void UpdateDomicilio()
        {
            bool deliveryOn = DeliveryOn;
            pnlTipo.Visible = deliveryOn;
            badgeDelivery.Visible = deliveryOn;
            pnlDomicilio.Visible = deliveryOn && IsDomicilio;

            if (IsDomicilio)
            {
                string cliente = txtCliente.Text.Trim();
                string dir = txtDireccion.Text.Trim();
                lblDestino.Text = (cliente.Length > 0 ? cliente : "Cliente") + (dir.Length > 0 ? " · " + dir : "");
            }
            else if (Tipo.Contains("Para llevar")) lblDestino.Text = "Para llevar";
            else lblDestino.Text = _table;
        }

        // ===================== Cobro =====================

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (_ticket.Count == 0)
            {
                MessageBox.Show("Agregue productos al ticket antes de cobrar.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool isDom = IsDomicilio;
            if (isDom && (string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text)))
            {
                MessageBox.Show("Para domicilio completa cliente y dirección.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = _ticket.Sum(x => x.LineTotal);
            decimal total = subtotal * (1 + _taxRate);
            string destino = isDom
                ? "Domicilio: " + txtCliente.Text.Trim() + " · " + txtDireccion.Text.Trim()
                : (Tipo.Contains("Para llevar") ? "Para llevar" : _table);

            using (var checkout = new CheckoutDialog(total, destino))
            {
                if (checkout.ShowDialog(FindForm()) != DialogResult.OK || !checkout.PaymentConfirmed) return;

                var receipt = new StringBuilder();
                receipt.AppendLine("RESTOOS");
                receipt.AppendLine("Recibo de demostración");
                receipt.AppendLine("Tipo: " + Tipo);
                if (!string.IsNullOrWhiteSpace(destino) && destino != TicketStore.NoTable) receipt.AppendLine(destino);
                if (isDom)
                {
                    receipt.AppendLine("Tel: " + txtTelefono.Text.Trim());
                    receipt.AppendLine("Dir: " + txtDireccion.Text.Trim());
                }
                receipt.AppendLine("----------------------------");
                foreach (var line in _ticket)
                {
                    receipt.AppendLine(line.Name + (line.Quantity > 1 ? " x" + line.Quantity : "") + "  " + line.TotalText);
                    if (!string.IsNullOrEmpty(line.Notes)) receipt.AppendLine("  > " + line.Notes);
                }
                receipt.AppendLine("----------------------------");
                receipt.AppendLine("Subtotal: " + Money(subtotal));
                receipt.AppendLine("Impuesto (" + (_taxRate * 100).ToString("0") + "%): " + Money(subtotal * _taxRate));
                receipt.AppendLine("Total: " + Money(total));
                receipt.AppendLine("Pago: " + checkout.PaymentMethod);
                receipt.AppendLine("Recibido: " + Money(checkout.PaidAmount));
                receipt.AppendLine("Vuelto: " + Money(checkout.ChangeAmount));

                using (var preview = new ReceiptDialog(receipt.ToString()))
                    preview.ShowDialog(FindForm());
            }

            _ticket.Clear();
            if (isDom)
            {
                txtCliente.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                cmbTipo.SelectedIndex = 0;
            }
            RefreshTicket();
            UpdateDomicilio();
        }

        private static string Money(decimal value) => value.ToString("C0", Co);
    }
}
