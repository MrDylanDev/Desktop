using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string text)
        {
            InitializeComponent();
            
            txtReceipt.Text = text;
            
            btnPrint.Click += (s, e) => { MessageBox.Show("Simulando impresión..."); };
            btnClose.Click += (s, e) => { this.Close(); };
        }
    }
}
