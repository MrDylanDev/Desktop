using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>Vista previa del recibo con impresión por la impresora de Windows (ReceiptWindow de WPF).</summary>
    public partial class ReceiptDialog : RDialogForm
    {
        private string _text;

        public ReceiptDialog() : this(string.Empty) { }

        public ReceiptDialog(string receiptText)
        {
            InitializeComponent();
            _text = receiptText ?? string.Empty;
            txtReceipt.Text = _text.Replace("\r\n", "\n").Replace("\n", Environment.NewLine);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            using (var doc = new PrintDocument { DocumentName = "Recibo RestoOS" })
            using (var dialog = new PrintDialog { Document = doc, UseEXDialog = true })
            {
                doc.PrintPage += (s, args) =>
                {
                    using (var font = new Font("Consolas", 9F))
                        args.Graphics.DrawString(_text, font, Brushes.Black, args.MarginBounds);
                };
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                try { doc.Print(); }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo imprimir: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
