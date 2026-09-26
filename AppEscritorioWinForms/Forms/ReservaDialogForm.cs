using System;
using System.Drawing;
using System.Windows.Forms;


namespace app_escritorio.Forms
{
    public partial class ReservaDialogForm : Form
    {
        public ReservasForm.Reserva Result { get; private set; }

        public ReservaDialogForm(ReservasForm.Reserva r, DateTime defaultDate)
        {
            InitializeComponent();

            this.Text = r == null ? "Nueva reserva" : "Editar reserva";
            titleLabel.Text = this.Text;

            if (r != null)
            {
                fechaPicker.Value = r.Fecha.Date;
                horaBox.Text = r.Fecha.ToString("HH:mm");
                clienteBox.Text = r.Cliente;
                personasBox.Text = r.Personas.ToString();
                mesaBox.Text = r.Mesa;
                telBox.Text = r.Telefono;
                estadoBox.SelectedItem = r.Estado;
            }
            else
            {
                fechaPicker.Value = defaultDate.Date;
                horaBox.Text = "19:00";
                personasBox.Text = "2";
                mesaBox.Text = "Mesa 1";
                estadoBox.SelectedIndex = 0;
            }
        }

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

            DateTime fecha = fechaPicker.Value.Date;
            if (TimeSpan.TryParse(horaBox.Text.Trim(), out TimeSpan hora))
            {
                fecha = fecha.Add(hora);
            }
            else
            {
                fecha = fecha.AddHours(19);
            }

            int personas = 2;
            if (int.TryParse(personasBox.Text.Trim(), out int p) && p > 0) personas = p;

            string mesa = mesaBox.Text.Trim();
            if (string.IsNullOrEmpty(mesa)) mesa = "Mesa 1";

            string estado = estadoBox.SelectedItem?.ToString() ?? "Confirmada";
            string tel = telBox.Text.Trim();

            Result = new ReservasForm.Reserva(fecha, cliente, personas, mesa, estado, tel);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
