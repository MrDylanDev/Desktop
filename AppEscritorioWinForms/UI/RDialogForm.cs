using System;
using System.ComponentModel;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>
    /// Base para ventanas de diálogo con el tema oscuro (barra de título oscura en Windows 10/11).
    /// Crea un diálogo nuevo con Agregar → Formulario heredado → RDialogForm.
    /// </summary>
    public class RDialogForm : Form
    {
        public RDialogForm()
        {
            BackColor = Theme.Surface;
            ForeColor = Theme.OnSurface;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            KeyPreview = true;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UiHelpers.ApplyDarkTitleBar(this);
        }
    }
}
