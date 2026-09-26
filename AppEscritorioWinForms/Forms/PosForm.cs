using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Forms
{
    public partial class PosForm : Form
    {
        public string Role { get; set; }
        // Los tickets viven ahora en Data.TicketStore (compartidos con el POS nuevo y con Mesas).
        public static BindingList<OrderLine> GetTicketFor(string mesa) => app_escritorio.Data.TicketStore.GetTicketFor(mesa);

        private readonly List<Product> _products = new List<Product>();
        private BindingList<OrderLine> _ticket;
        private string _table = "Mesa no seleccionada";
        private decimal _taxRate = 0.08m;

        public PosForm()
        {
            InitializeComponent();
            LoadProducts();
            _ticket = GetTicketFor(_table);
            RefreshTicket();
        }

        public void SetMesa(string mesaName)
        {
            _table = string.IsNullOrWhiteSpace(mesaName) ? "Mesa no seleccionada" : mesaName;
            lblMesa.Text = _table;
            _ticket = GetTicketFor(_table);
            RefreshTicket();
        }

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
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            productsPanel.SuspendLayout();
            productsPanel.Controls.Clear();
            string text = searchBox.Text.Trim().ToLowerInvariant();
            string category = categoryBox.SelectedItem?.ToString() ?? "Todos";

            foreach (var p in _products)
            {
                if (category != "Todos" && p.Category != category) continue;
                if (!string.IsNullOrEmpty(text) && !p.Name.ToLowerInvariant().Contains(text)) continue;

                var btn = new Button
                {
                    Text = $"{p.Name}\n{p.PriceText}",
                    Size = new Size(180, 100),
                    BackColor = Color.FromArgb(40, 42, 44),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(5)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Tag = p;
                btn.Click += Product_Click;
                productsPanel.Controls.Add(btn);
            }
            productsPanel.ResumeLayout();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            var p = (sender as Button)?.Tag as Product;
            if (p == null) return;
            var line = _ticket.FirstOrDefault(x => x.Product.Name == p.Name);
            if (line == null) _ticket.Add(new OrderLine(p));
            else line.Quantity++;
            RefreshTicket();
        }

        private void TicketGrid_DoubleClick(object sender, EventArgs e)
        {
            if (ticketGrid.SelectedRows.Count == 0) return;
            var line = ticketGrid.SelectedRows[0].DataBoundItem as OrderLine;
            if (line != null)
            {
                line.Quantity--;
                if (line.Quantity <= 0) _ticket.Remove(line);
                RefreshTicket();
            }
        }

        private void RefreshTicket()
        {
            ticketGrid.DataSource = null;
            ticketGrid.DataSource = _ticket;
            
            decimal subtotal = _ticket.Sum(x => x.LineTotal);
            decimal tax = subtotal * _taxRate;
            lblSubtotal.Text = $"Subtotal: {subtotal.ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}";
            lblTax.Text = $"Impuesto: {tax.ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}";
            lblTotal.Text = $"Total: {(subtotal + tax).ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}";
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            if (_ticket.Count == 0)
            {
                MessageBox.Show("Agregue productos al ticket antes de cobrar.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = _ticket.Sum(x => x.LineTotal) * (1 + _taxRate);
            var checkout = new CheckoutForm(total, _table);
            if (checkout.ShowDialog(this) == DialogResult.OK && checkout.PaymentConfirmed)
            {
                var receipt = new StringBuilder();
                receipt.AppendLine("RESTOOS");
                receipt.AppendLine("Recibo de demostración");
                receipt.AppendLine("----------------------------");
                foreach (OrderLine line in _ticket)
                {
                    receipt.AppendLine(line.Name + "  " + line.TotalText);
                }
                receipt.AppendLine("----------------------------");
                decimal subtotal = _ticket.Sum(x => x.LineTotal);
                receipt.AppendLine("Subtotal: " + subtotal.ToString("C0", CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Impuesto (" + (_taxRate * 100).ToString("0") + "%): " + (subtotal * _taxRate).ToString("C0", CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Total: " + total.ToString("C0", CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Pago: " + checkout.PaymentMethod);
                receipt.AppendLine("Recibido: " + checkout.PaidAmount.ToString("C0", CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Vuelto: " + checkout.ChangeAmount.ToString("C0", CultureInfo.GetCultureInfo("es-CO")));
                
                var receiptForm = new ReceiptForm(receipt.ToString());
                receiptForm.ShowDialog();
                
                _ticket.Clear();
                RefreshTicket();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string PriceText => Price.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));
        public Product(string name, string category, decimal price) { Name = name; Category = category; Price = price; }
    }

    public class OrderLine
    {
        public Product Product { get; private set; }
        public string Name => Product.Name;
        public int Quantity { get; set; } = 1;
        /// <summary>Nota del ítem ("sin cebolla", "término medio").</summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>Precio unitario formateado ("$ 14.500 c/u").</summary>
        public string Detail => Product.PriceText + " c/u";
        public decimal LineTotal => Product.Price * Quantity;
        public string TotalText => LineTotal.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));

        public OrderLine(Product product) { Product = product; }
    }
}





