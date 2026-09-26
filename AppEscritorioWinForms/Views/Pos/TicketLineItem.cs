using System;
using System.ComponentModel;
using app_escritorio.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>Línea del ticket (nombre, precio c/u, nota, − cantidad +, ×, total y botón Nota), como en WPF.</summary>
    [ToolboxItem(false)]
    public partial class TicketLineItem : RCardControl
    {
        private const int HeightWithoutNotes = 92;
        private const int HeightWithNotes = 110;

        public event EventHandler PlusClicked;
        public event EventHandler MinusClicked;
        public event EventHandler RemoveClicked;
        public event EventHandler NoteClicked;

        public TicketLineItem()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrderLine Line { get; private set; }

        public void SetLine(OrderLine line)
        {
            Line = line;
            if (line == null) return;
            lblName.Text = line.Name + (line.Quantity > 1 ? "  x" + line.Quantity : string.Empty);
            lblDetail.Text = line.Detail;
            lblQty.Text = line.Quantity.ToString();
            lblTotal.Text = line.TotalText;

            bool hasNotes = !string.IsNullOrWhiteSpace(line.Notes);
            lblNotes.Text = hasNotes ? line.Notes : string.Empty;
            lblNotes.Visible = hasNotes;
            Height = hasNotes ? HeightWithNotes : HeightWithoutNotes;
        }

        private void BtnPlus_Click(object sender, EventArgs e) => PlusClicked?.Invoke(this, EventArgs.Empty);
        private void BtnMinus_Click(object sender, EventArgs e) => MinusClicked?.Invoke(this, EventArgs.Empty);
        private void BtnRemove_Click(object sender, EventArgs e) => RemoveClicked?.Invoke(this, EventArgs.Empty);
        private void BtnNote_Click(object sender, EventArgs e) => NoteClicked?.Invoke(this, EventArgs.Empty);
    }
}
