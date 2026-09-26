using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace app_escritorio.Forms
{
    public partial class DeliveryDialogForm : Form
    {
        public DeliveryForm.PedidoDelivery Result { get; private set; }

        public DeliveryDialogForm(DeliveryForm.PedidoDelivery p)
        {
            InitializeComponent();

            this.Text = p == null ? "Nuevo pedido" : "Editar pedido";
            titleLabel.Text = this.Text;

            if (p != null)
            {
                plataformaBox.SelectedItem = p.Plataforma;
                idBox.Text = p.Id;
                fechaPicker.Value = p.Fecha.Date;
                horaBox.Text = p.Fecha.ToString("HH:mm");
                clienteBox.Text = p.Cliente;
                detalleBox.Text = p.Detalle;
                totalBox.Text = p.Total.ToString("0", CultureInfo.InvariantCulture);
                estadoBox.SelectedItem = p.Estado;
            }
            else
            {
                plataformaBox.SelectedIndex = 0;
                idBox.Text = SugerirId();
                fechaPicker.Value = DateTime.Today;
                horaBox.Text = "12:00";
                estadoBox.SelectedIndex = 0;
            }
        }

        private static string SugerirId() => "#N-" + DateTime.Now.ToString("HHmmss");

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string cliente = clienteBox.Text.Trim();
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Cliente requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string detalle = detalleBox.Text.Trim();
            if (string.IsNullOrEmpty(detalle))
            {
                MessageBox.Show("Detalle requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = idBox.Text.Trim();
            if (string.IsNullOrEmpty(id)) id = SugerirId();

            string raw = totalBox.Text.Trim().Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
            if (!decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total) || total <= 0)
            {
                MessageBox.Show("Total inválido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime fecha = fechaPicker.Value.Date;
            if (TimeSpan.TryParse(horaBox.Text.Trim(), out TimeSpan hora))
            {
                fecha = fecha.Add(hora);
            }
            else
            {
                fecha = fecha.AddHours(12);
            }

            Result = new DeliveryForm.PedidoDelivery(
                fecha,
                plataformaBox.SelectedItem?.ToString() ?? "Rappi",
                id, cliente, detalle, total,
                estadoBox.SelectedItem?.ToString() ?? "Nuevo"
            );
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
