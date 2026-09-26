using System;
using System.ComponentModel;
using System.Drawing;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Views.Modulos
{
    /// <summary>
    /// Tarjeta de un módulo (ícono, título, descripción e interruptor "Módulo activado").
    /// Todas sus propiedades se editan en la ventana Propiedades (categoría RestoOS) desde ModulesView.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("ModuleToggled")]
    public partial class ModuleCard : RCardControl
    {
        /// <summary>El usuario activó o desactivó el módulo.</summary>
        public event EventHandler ModuleToggled;

        private bool _isCore;

        public ModuleCard()
        {
            InitializeComponent();
        }

        [Category("RestoOS"), DefaultValue(""), Description("Clave del módulo (salon, menu, kds, inventario, reservas, delivery, reportes).")]
        public string ModuleKey { get; set; } = "";

        [Category("RestoOS"), Description("Ícono (carácter Unicode)."), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Glyph { get => lblGlyph.Text; set => lblGlyph.Text = value; }

        [Category("RestoOS"), Description("Color del ícono.")]
        public Color GlyphColor { get => lblGlyph.ColorOverride; set => lblGlyph.ColorOverride = value; }

        [Category("RestoOS"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }

        [Category("RestoOS"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Description { get => lblDescription.Text; set => lblDescription.Text = value; }

        [Category("RestoOS"), DefaultValue(false), Description("Módulo núcleo: siempre activo, sin interruptor.")]
        public bool IsCore
        {
            get => _isCore;
            set
            {
                _isCore = value;
                swActive.Visible = lblStatus.Visible = !value;
                lblCore.Visible = value;
            }
        }

        [Category("RestoOS"), DefaultValue(true)]
        public bool ModuleEnabled
        {
            get => swActive.Checked;
            set { swActive.Checked = value; UpdateStatus(); }
        }

        private void UpdateStatus()
        {
            bool on = swActive.Checked;
            lblStatus.Text = on ? "Módulo activo" : "Módulo desactivado";
            lblStatus.ColorOverride = on ? Theme.Tertiary : Theme.OnSurfaceVariant;
        }

        private void SwActive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatus();
            ModuleToggled?.Invoke(this, EventArgs.Empty);
        }
    }
}
