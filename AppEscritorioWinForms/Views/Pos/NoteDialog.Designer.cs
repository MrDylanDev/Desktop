namespace app_escritorio.Views.Pos
{
    partial class NoteDialog
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
            this.lblSubtitle = new app_escritorio.UI.RLabel();
            this.txtNote = new app_escritorio.UI.RTextBox();
            this.lblHint = new app_escritorio.UI.RLabel();
            this.btnCancel = new app_escritorio.UI.RButton();
            this.btnSave = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnSave);
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.lblHint);
            this.root.Controls.Add(this.txtNote);
            this.root.Controls.Add(this.lblSubtitle);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(20);
            this.root.Size = new System.Drawing.Size(424, 236);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nota para el plato";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(20, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(384, 18);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ej: sin cebolla, término medio, extra queso";
            this.lblSubtitle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(20, 76);
            this.txtNote.MaxLength = 120;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(384, 84);
            this.txtNote.TabIndex = 0;
            // 
            // lblHint
            // 
            this.lblHint.Location = new System.Drawing.Point(254, 162);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(150, 16);
            this.lblHint.TabIndex = 3;
            this.lblHint.Text = "120 caracteres máx.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHint.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(174, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NoteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 236);
            this.Controls.Add(this.root);
            this.Name = "NoteDialog";
            this.Text = "Nota del pedido";
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblSubtitle;
        private app_escritorio.UI.RTextBox txtNote;
        private app_escritorio.UI.RLabel lblHint;
        private app_escritorio.UI.RButton btnCancel;
        private app_escritorio.UI.RButton btnSave;
    }
}
