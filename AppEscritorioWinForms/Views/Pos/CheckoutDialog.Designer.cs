namespace app_escritorio.Views.Pos
{
    partial class CheckoutDialog
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.root = new app_escritorio.UI.RPanel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.lblMesa = new app_escritorio.UI.RLabel();
            this.cardTotal = new app_escritorio.UI.RPanel();
            this.lblTotalCaption = new app_escritorio.UI.RLabel();
            this.lblTotalValue = new app_escritorio.UI.RLabel();
            this.btnCash = new app_escritorio.UI.RButton();
            this.btnCard = new app_escritorio.UI.RButton();
            this.numpad = new System.Windows.Forms.TableLayoutPanel();
            this.btn7 = new app_escritorio.UI.RButton();
            this.btn8 = new app_escritorio.UI.RButton();
            this.btn9 = new app_escritorio.UI.RButton();
            this.btn4 = new app_escritorio.UI.RButton();
            this.btn5 = new app_escritorio.UI.RButton();
            this.btn6 = new app_escritorio.UI.RButton();
            this.btn1 = new app_escritorio.UI.RButton();
            this.btn2 = new app_escritorio.UI.RButton();
            this.btn3 = new app_escritorio.UI.RButton();
            this.btnClear = new app_escritorio.UI.RButton();
            this.btn0 = new app_escritorio.UI.RButton();
            this.btnDot = new app_escritorio.UI.RButton();
            this.lblPaidCaption = new app_escritorio.UI.RLabel();
            this.txtPaid = new app_escritorio.UI.RTextBox();
            this.lblChangeCaption = new app_escritorio.UI.RLabel();
            this.lblChange = new app_escritorio.UI.RLabel();
            this.btnFinish = new app_escritorio.UI.RButton();
            this.btnCancel = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.numpad.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.btnFinish);
            this.root.Controls.Add(this.lblChange);
            this.root.Controls.Add(this.lblChangeCaption);
            this.root.Controls.Add(this.txtPaid);
            this.root.Controls.Add(this.lblPaidCaption);
            this.root.Controls.Add(this.numpad);
            this.root.Controls.Add(this.btnCard);
            this.root.Controls.Add(this.btnCash);
            this.root.Controls.Add(this.cardTotal);
            this.root.Controls.Add(this.lblMesa);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(484, 604);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cobro de venta";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // lblMesa
            // 
            this.lblMesa.Location = new System.Drawing.Point(24, 60);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(436, 20);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa no seleccionada";
            this.lblMesa.TextStyle = app_escritorio.UI.TextStyle.Accent;
            // 
            // cardTotal
            // 
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Controls.Add(this.lblTotalCaption);
            this.cardTotal.CornerRadius = 12;
            this.cardTotal.Location = new System.Drawing.Point(24, 96);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(436, 68);
            this.cardTotal.TabIndex = 2;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 24);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(140, 20);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total a cobrar";
            this.lblTotalCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Location = new System.Drawing.Point(160, 12);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(260, 44);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "$ 0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalValue.TextStyle = app_escritorio.UI.TextStyle.TotalLarge;
            // 
            // btnCash
            // 
            this.btnCash.Selected = true;
            this.btnCash.Location = new System.Drawing.Point(24, 178);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(120, 36);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "Efectivo";
            this.btnCash.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.btnCash.Click += new System.EventHandler(this.BtnPaymentMode_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(152, 178);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(120, 36);
            this.btnCard.TabIndex = 4;
            this.btnCard.Text = "Tarjeta";
            this.btnCard.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.btnCard.Click += new System.EventHandler(this.BtnPaymentMode_Click);
            // 
            // numpad
            // 
            this.numpad.ColumnCount = 3;
            this.numpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.numpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.numpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.numpad.Controls.Add(this.btn7, 0, 0);
            this.numpad.Controls.Add(this.btn8, 1, 0);
            this.numpad.Controls.Add(this.btn9, 2, 0);
            this.numpad.Controls.Add(this.btn4, 0, 1);
            this.numpad.Controls.Add(this.btn5, 1, 1);
            this.numpad.Controls.Add(this.btn6, 2, 1);
            this.numpad.Controls.Add(this.btn1, 0, 2);
            this.numpad.Controls.Add(this.btn2, 1, 2);
            this.numpad.Controls.Add(this.btn3, 2, 2);
            this.numpad.Controls.Add(this.btnClear, 0, 3);
            this.numpad.Controls.Add(this.btn0, 1, 3);
            this.numpad.Controls.Add(this.btnDot, 2, 3);
            this.numpad.Location = new System.Drawing.Point(20, 226);
            this.numpad.Name = "numpad";
            this.numpad.RowCount = 4;
            this.numpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numpad.Size = new System.Drawing.Size(290, 240);
            this.numpad.TabIndex = 5;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Padding = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(88, 52);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn7.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Padding = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 52);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn8.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Padding = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(88, 52);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn9.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Padding = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 52);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn4.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Padding = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 52);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn5.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Padding = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(88, 52);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn6.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Padding = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 52);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn1.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Padding = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 52);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn2.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Padding = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 52);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn3.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Padding = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 52);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.Variant = app_escritorio.UI.ButtonVariant.Danger;
            this.btnClear.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Padding = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 52);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btn0.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btnDot
            // 
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Margin = new System.Windows.Forms.Padding(4);
            this.btnDot.Padding = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(88, 52);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.Variant = app_escritorio.UI.ButtonVariant.Numpad;
            this.btnDot.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // lblPaidCaption
            // 
            this.lblPaidCaption.Location = new System.Drawing.Point(320, 230);
            this.lblPaidCaption.Name = "lblPaidCaption";
            this.lblPaidCaption.Size = new System.Drawing.Size(140, 18);
            this.lblPaidCaption.TabIndex = 6;
            this.lblPaidCaption.Text = "Monto recibido";
            this.lblPaidCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtPaid
            // 
            this.txtPaid.LargeText = true;
            this.txtPaid.Location = new System.Drawing.Point(320, 252);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(140, 46);
            this.txtPaid.TabIndex = 7;
            this.txtPaid.TabStop = false;
            this.txtPaid.Text = "$ 0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblChangeCaption
            // 
            this.lblChangeCaption.Location = new System.Drawing.Point(320, 314);
            this.lblChangeCaption.Name = "lblChangeCaption";
            this.lblChangeCaption.Size = new System.Drawing.Size(140, 18);
            this.lblChangeCaption.TabIndex = 8;
            this.lblChangeCaption.Text = "Vuelto";
            this.lblChangeCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblChange
            // 
            this.lblChange.Location = new System.Drawing.Point(320, 336);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(140, 36);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "$ 0";
            this.lblChange.TextStyle = app_escritorio.UI.TextStyle.Success;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(24, 486);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(436, 52);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finalizar pago";
            this.btnFinish.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(24, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(436, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // CheckoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 604);
            this.Controls.Add(this.root);
            this.Name = "CheckoutDialog";
            this.Text = "Cobrar venta";
            this.numpad.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblMesa;
        private app_escritorio.UI.RPanel cardTotal;
        private app_escritorio.UI.RLabel lblTotalCaption;
        private app_escritorio.UI.RLabel lblTotalValue;
        private app_escritorio.UI.RButton btnCash;
        private app_escritorio.UI.RButton btnCard;
        private System.Windows.Forms.TableLayoutPanel numpad;
        private app_escritorio.UI.RButton btn7;
        private app_escritorio.UI.RButton btn8;
        private app_escritorio.UI.RButton btn9;
        private app_escritorio.UI.RButton btn4;
        private app_escritorio.UI.RButton btn5;
        private app_escritorio.UI.RButton btn6;
        private app_escritorio.UI.RButton btn1;
        private app_escritorio.UI.RButton btn2;
        private app_escritorio.UI.RButton btn3;
        private app_escritorio.UI.RButton btnClear;
        private app_escritorio.UI.RButton btn0;
        private app_escritorio.UI.RButton btnDot;
        private app_escritorio.UI.RLabel lblPaidCaption;
        private app_escritorio.UI.RTextBox txtPaid;
        private app_escritorio.UI.RLabel lblChangeCaption;
        private app_escritorio.UI.RLabel lblChange;
        private app_escritorio.UI.RButton btnFinish;
        private app_escritorio.UI.RButton btnCancel;
    }
}
