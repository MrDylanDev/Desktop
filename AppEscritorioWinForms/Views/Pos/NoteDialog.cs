using System;
using System.Windows.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>Nota por ítem ("sin cebolla", "término medio"), igual a NoteWindow de WPF.</summary>
    public partial class NoteDialog : RDialogForm
    {
        public string NoteResult { get; private set; } = string.Empty;

        public NoteDialog() : this("Nota para el plato", string.Empty) { }

        public NoteDialog(string productName, string currentNote)
        {
            InitializeComponent();
            lblTitle.Text = string.IsNullOrWhiteSpace(productName) ? "Nota para el plato" : productName;
            txtNote.Text = currentNote ?? string.Empty;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtNote.Focus();
            txtNote.SelectAll();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            NoteResult = (txtNote.Text ?? string.Empty).Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
