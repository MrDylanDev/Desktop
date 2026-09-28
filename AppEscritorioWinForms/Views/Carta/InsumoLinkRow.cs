using System;
using System.ComponentModel;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Views.Carta
{
    /// <summary>Fila de un insumo vinculado a un plato ("Ojo de bife madurado · -0,4 kg · ×").</summary>
    [ToolboxItem(true)]
    public partial class InsumoLinkRow : RCardControl
    {
        public event EventHandler RemoveClicked;

        public InsumoLinkRow()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public InsumoLink Link { get; private set; }

        public void SetLink(InsumoLink link)
        {
            Link = link;
            lblNombre.Text = link.Nombre;
            chipCantidad.Text = link.CantidadText;
            chipCantidad.Left = btnQuitar.Left - chipCantidad.Width - 8;
            lblNombre.Width = chipCantidad.Left - lblNombre.Left - 6;
        }

        private void BtnQuitar_Click(object sender, EventArgs e) => RemoveClicked?.Invoke(this, EventArgs.Empty);
    }
}
