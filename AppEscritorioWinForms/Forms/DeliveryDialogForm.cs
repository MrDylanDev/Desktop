using System;
using System.Globalization;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>Crear o editar un pedido de delivery.</summary>
    public partial class DeliveryDialogForm : RDialogForm
    {
        public PedidoDelivery Result { get; private set; }

        public DeliveryDialogForm() : this(null) { }

        public DeliveryDialogForm(PedidoDelivery p)
        {
            InitializeComponent();
            if (p == null)
            {
                Text = lblTitle.Text = "Nuevo pedido";
                cmbPlataforma.SelectedIndex = 0;
                txtId.Text = SugerirId();
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtHora.Text = DateTime.Now.ToString("HH:mm");
                cmbEstado.SelectedIndex = 0;
                return;
            }
            Text = lblTitle.Text = "Editar pedido";
            int i = cmbPlataforma.Items.IndexOf(p.Plataforma);
            cmbPlataforma.SelectedIndex = i >= 0 ? i : 0;
            txtId.Text = p.Id;
            txtFecha.Text = p.Fecha.ToString("dd/MM/yyyy");
            txtHora.Text = p.Fecha.ToString("HH:mm");
            txtCliente.Text = p.Cliente;
            txtDetalle.Text = p.Detalle;
            txtTotal.Text = p.Total.ToString("0", CultureInfo.InvariantCulture);
            int e = cmbEstado.Items.IndexOf(p.Estado);
            cmbEstado.SelectedIndex = e >= 0 ? e : 0;
        }

        private static string SugerirId() => "#N-" + DateTime.Now.ToString("HHmmss");

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtCliente.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim(), detalle = txtDetalle.Text.Trim();
            if (cliente.Length == 0 || detalle.Length == 0)
            {
                MessageBox.Show(cliente.Length == 0 ? "Cliente requerido." : "Detalle requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string raw = txtTotal.Text.Trim().Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
            if (!decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total) || total <= 0)
            {
                MessageBox.Show("Total inválido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Focus();
                return;
            }
            if (!DateTime.TryParseExact(txtFecha.Text.Trim(), new[] { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                fecha = DateTime.Today;
            fecha = TimeSpan.TryParse(txtHora.Text.Trim(), out TimeSpan hora) ? fecha.Add(hora) : fecha.AddHours(12);
            string id = string.IsNullOrWhiteSpace(txtId.Text) ? SugerirId() : txtId.Text.Trim();

            Result = new PedidoDelivery(fecha, cmbPlataforma.SelectedItem?.ToString() ?? "Rappi", id, cliente, detalle, total,
                                        cmbEstado.SelectedItem?.ToString() ?? "Nuevo");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
