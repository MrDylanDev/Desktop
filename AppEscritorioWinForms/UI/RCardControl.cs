using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>
    /// Base para tarjetas diseñables (UserControl con fondo redondeado y hover opcional).
    /// Hereda de esta clase para crear tarjetas propias y editarlas en el diseñador.
    /// </summary>
    public class RCardControl : UserControl, ISurfaceProvider
    {
        private SurfaceLevel _surface = SurfaceLevel.High;
        private SurfaceLevel _hoverSurface = SurfaceLevel.High;
        private int _cornerRadius = 8;
        private bool _hover;
        private Color _borderColor = Color.Empty;
        private int _borderWidth = 2;

        public RCardControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = UiHelpers.ColorOf(_surface);
        }

        [Category("RestoOS"), DefaultValue(SurfaceLevel.High)]
        public SurfaceLevel Surface
        {
            get => _surface;
            set { _surface = value; base.BackColor = UiHelpers.ColorOf(value); Invalidate(true); }
        }

        [Category("RestoOS"), DefaultValue(SurfaceLevel.High)]
        [Description("Superficie al pasar el mouse. Igual a Surface = sin efecto hover.")]
        public SurfaceLevel HoverSurface
        {
            get => _hoverSurface;
            set { _hoverSurface = value; Invalidate(true); }
        }

        [Category("RestoOS"), DefaultValue(8)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        [Category("RestoOS"), DefaultValue(typeof(Color), "")]
        [Description("Color del borde (vacío = sin borde). Ej.: color del estado de la mesa.")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("RestoOS"), DefaultValue(2)]
        public int BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = Math.Max(1, value); Invalidate(); }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false)]
        public Color SurfaceColor => UiHelpers.ColorOf(_hover ? _hoverSurface : _surface);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));
            UiHelpers.FillRounded(e.Graphics, SurfaceColor, ClientRectangle, _cornerRadius);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!_borderColor.IsEmpty)
                UiHelpers.DrawRounded(e.Graphics, _borderColor, ClientRectangle, _cornerRadius, _borderWidth);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.MouseEnter += Child_MouseChanged;
            e.Control.MouseLeave += Child_MouseChanged;
        }

        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); UpdateHover(); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); UpdateHover(); }
        private void Child_MouseChanged(object sender, EventArgs e) => UpdateHover();

        private void UpdateHover()
        {
            bool inside = ClientRectangle.Contains(PointToClient(Cursor.Position));
            if (inside == _hover) return;
            _hover = inside;
            base.BackColor = SurfaceColor;
            Invalidate(true);
        }
    }
}
