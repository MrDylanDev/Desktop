using System;
using System.ComponentModel;
using app_escritorio.Data;
using app_escritorio.UI;

namespace app_escritorio.Views.Mesas
{
    /// <summary>Tarjeta de mesa (número, estado, capacidad, total y acciones) con borde del color del estado.</summary>
    [ToolboxItem(false)]
    public partial class TableCard : RCardControl
    {
        public event EventHandler CardClicked;
        public event EventHandler OpenClicked;
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public TableCard()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MesaInfo Mesa { get; private set; }

        public void SetMesa(MesaInfo mesa)
        {
            Mesa = mesa;
            if (mesa == null) return;
            lblNumber.Text = mesa.Number;
            lblStatus.Text = mesa.Status;
            lblStatus.ColorOverride = mesa.StatusColor;
            lblCapacity.Text = mesa.Capacity;
            lblTotal.Text = mesa.Total;
            BorderColor = mesa.StatusColor;
            btnOpen.Enabled = mesa.CanOpen;
        }

        private void Card_Click(object sender, EventArgs e) => CardClicked?.Invoke(this, EventArgs.Empty);
        private void BtnOpen_Click(object sender, EventArgs e) => OpenClicked?.Invoke(this, EventArgs.Empty);
        private void BtnEdit_Click(object sender, EventArgs e) => EditClicked?.Invoke(this, EventArgs.Empty);
        private void BtnDelete_Click(object sender, EventArgs e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
    }
}
