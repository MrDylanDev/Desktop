using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.UI
{
    /// <summary>
    /// Panel con el fondo de la paleta y esquinas redondeadas suaves (equivale a Border / Style="Card" de WPF).
    /// Elige el color con <see cref="Surface"/>; BackColor queda oculto para que el tema se aplique solo.
    /// </summary>
    [ToolboxItem(true)]
    [Description("Panel temático RestoOS (fondo de paleta + esquinas redondeadas).")]
    public class RPanel : Panel
    {
        private SurfaceLevel _surface = SurfaceLevel.Container;
        private int _cornerRadius;
        private bool _bottomBorder;

        public RPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            ApplySurface();
        }

        [Category("RestoOS"), DefaultValue(SurfaceLevel.Container)]
        [Description("Color de fondo según la paleta (Surface, Lowest, Container, High, Highest).")]
        public SurfaceLevel Surface
        {
            get => _surface;
            set { _surface = value; ApplySurface(); Invalidate(true); }
        }

        [Category("RestoOS"), DefaultValue(0)]
        [Description("Radio de las esquinas en píxeles (WPF Card = 14).")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("RestoOS"), DefaultValue(false)]
        [Description("Dibuja una línea inferior color Outline (como la barra superior de WPF).")]
        public bool BottomBorder
        {
            get => _bottomBorder;
            set { _bottomBorder = value; Invalidate(); }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set { /* lo controla Surface */ }
        }

        private void ApplySurface()
        {
            base.BackColor = _surface == SurfaceLevel.Transparent ? Color.Transparent : UiHelpers.ColorOf(_surface);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (_surface == SurfaceLevel.Transparent)
            {
                base.OnPaintBackground(e);
            }
            else if (_cornerRadius > 0)
            {
                e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));
                UiHelpers.FillRounded(e.Graphics, UiHelpers.ColorOf(_surface), ClientRectangle, _cornerRadius);
            }
            else
            {
                e.Graphics.Clear(UiHelpers.ColorOf(_surface));
            }

            if (_bottomBorder)
            {
                using (var pen = new Pen(Utils.Theme.Outline))
                    e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }

    /// <summary>FlowLayoutPanel con fondo de paleta y scrollbars oscuros (listas de productos, ticket...).</summary>
    [ToolboxItem(true)]
    [Description("FlowLayoutPanel temático RestoOS.")]
    public class RFlowPanel : FlowLayoutPanel
    {
        private SurfaceLevel _surface = SurfaceLevel.Surface;

        public RFlowPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            base.BackColor = UiHelpers.ColorOf(_surface);
        }

        [Category("RestoOS"), DefaultValue(SurfaceLevel.Surface)]
        public SurfaceLevel Surface
        {
            get => _surface;
            set
            {
                _surface = value;
                base.BackColor = value == SurfaceLevel.Transparent ? Color.Transparent : UiHelpers.ColorOf(value);
                Invalidate(true);
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set { }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UiHelpers.ApplyDarkScrollbars(this);
        }
    }
}
