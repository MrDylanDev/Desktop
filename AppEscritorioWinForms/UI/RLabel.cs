using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>Estilos de texto, tomados de los TextBlock de la versión WPF.</summary>
    public enum TextStyle
    {
        /// <summary>13px, OnSurface.</summary>
        Body,
        /// <summary>13px negrita, OnSurface.</summary>
        BodyBold,
        /// <summary>12px, OnSurfaceVariant (textos secundarios).</summary>
        Muted,
        /// <summary>11px, OnSurfaceVariant.</summary>
        Caption,
        /// <summary>11px negrita, Secondary (títulos de sección: OPERACIÓN, SUCURSAL ACTIVA...).</summary>
        Overline,
        /// <summary>13px, Secondary (mesa seleccionada, subtítulos de acento).</summary>
        Accent,
        /// <summary>13px negrita, Primary (precios).</summary>
        Price,
        /// <summary>18px negrita, Primary (totales).</summary>
        Total,
        /// <summary>18px negrita, OnSurface (título de diálogo).</summary>
        Heading,
        /// <summary>22px negrita (título de pantalla).</summary>
        Title,
        /// <summary>26px negrita (título grande).</summary>
        Display,
        /// <summary>24px negrita, Tertiary (vuelto, valores positivos).</summary>
        Success,
        /// <summary>Consolas negrita (reloj).</summary>
        Mono,
        /// <summary>18px negrita, Primary (logo RestoOS).</summary>
        Brand,
        /// <summary>11px, Tertiary (estado positivo: "Datos locales").</summary>
        Positive,
        /// <summary>14px, OnSurfaceVariant (ruta en la barra superior).</summary>
        Subtle,
        /// <summary>11px, Secondary (categoría de producto).</summary>
        AccentSmall,
        /// <summary>26px negrita, Primary (total a cobrar).</summary>
        TotalLarge,
        /// <summary>30px negrita (título de pantalla: "Mesas y Salón").</summary>
        Hero,
        /// <summary>28px negrita (número de mesa).</summary>
        Number,
        /// <summary>13px negrita, Secondary (totales de mesa).</summary>
        AccentBold
    }

    /// <summary>
    /// Label temático: eliges <see cref="TextStyle"/> y el color/tamaño salen de la paleta.
    /// Font y ForeColor quedan ocultos para que no se "congelen" en el Designer.cs.
    /// </summary>
    [ToolboxItem(true)]
    [Description("Texto temático RestoOS.")]
    public class RLabel : Label
    {
        private TextStyle _style = TextStyle.Body;

        public RLabel()
        {
            base.BackColor = Color.Transparent;
            ApplyStyle();
        }

        [Category("RestoOS"), DefaultValue(TextStyle.Body)]
        [Description("Estilo de texto de la paleta RestoOS.")]
        public TextStyle TextStyle
        {
            get => _style;
            set { _style = value; ApplyStyle(); }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get => base.Font;
            set { }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set { }
        }

        [DefaultValue(typeof(Color), "Transparent")]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        private void ApplyStyle()
        {
            switch (_style)
            {
                case TextStyle.BodyBold: Set(9.75F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.Muted: Set(9F, FontStyle.Regular, Theme.OnSurfaceVariant); break;
                case TextStyle.Caption: Set(8.25F, FontStyle.Regular, Theme.OnSurfaceVariant); break;
                case TextStyle.Overline: Set(8.25F, FontStyle.Bold, Theme.Secondary); break;
                case TextStyle.Accent: Set(9.75F, FontStyle.Regular, Theme.Secondary); break;
                case TextStyle.Price: Set(9.75F, FontStyle.Bold, Theme.Primary); break;
                case TextStyle.Total: Set(13.5F, FontStyle.Bold, Theme.Primary); break;
                case TextStyle.Heading: Set(13.5F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.Title: Set(16.5F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.Display: Set(19.5F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.Success: Set(18F, FontStyle.Bold, Theme.Tertiary); break;
                case TextStyle.Mono: base.Font = Theme.GetFont(10F, FontStyle.Bold, "Consolas"); base.ForeColor = _colorOverride.IsEmpty ? Theme.OnSurface : _colorOverride; break;
                case TextStyle.Brand: Set(13.5F, FontStyle.Bold, Theme.Primary); break;
                case TextStyle.Positive: Set(8.25F, FontStyle.Regular, Theme.Tertiary); break;
                case TextStyle.Subtle: Set(10.5F, FontStyle.Regular, Theme.OnSurfaceVariant); break;
                case TextStyle.AccentSmall: Set(8.25F, FontStyle.Regular, Theme.Secondary); break;
                case TextStyle.TotalLarge: Set(19.5F, FontStyle.Bold, Theme.Primary); break;
                case TextStyle.Hero: Set(22.5F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.Number: Set(21F, FontStyle.Bold, Theme.OnSurface); break;
                case TextStyle.AccentBold: Set(9.75F, FontStyle.Bold, Theme.Secondary); break;
                default: Set(9.75F, FontStyle.Regular, Theme.OnSurface); break;
            }
        }

        private void Set(float size, FontStyle style, Color color)
        {
            base.Font = Theme.GetFont(size, style);
            base.ForeColor = _colorOverride.IsEmpty ? color : _colorOverride;
        }

        private Color _colorOverride = Color.Empty;

        /// <summary>Color explícito para casos dinámicos (p. ej. color del estado de una mesa). Vacío = el del estilo.</summary>
        [Category("RestoOS"), DefaultValue(typeof(Color), "")]
        public Color ColorOverride
        {
            get => _colorOverride;
            set { _colorOverride = value; ApplyStyle(); }
        }
    }

    /// <summary>Etiqueta tipo "chip" con fondo redondeado (rol, "Operando local", "Solo Admin"...).</summary>
    public enum BadgeKind { Neutral, Success, Accent, Primary }

    [ToolboxItem(true)]
    [Description("Chip/insignia temática RestoOS.")]
    public class RBadge : Control
    {
        private BadgeKind _kind = BadgeKind.Neutral;
        private int _radius = 6;

        public RBadge()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            base.Font = Theme.GetFont(8.25F, FontStyle.Bold);
            Size = new Size(120, 26);
        }

        [Category("RestoOS"), DefaultValue(BadgeKind.Neutral)]
        public BadgeKind Kind { get => _kind; set { _kind = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(6)]
        public int CornerRadius { get => _radius; set { _radius = value; Invalidate(); } }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => base.Text; set { base.Text = value; Invalidate(); } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set { } }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color bg, fg;
            switch (_kind)
            {
                case BadgeKind.Success: bg = Theme.Tertiary; fg = Theme.OnTertiary; break;
                case BadgeKind.Accent: bg = Theme.SurfaceHigh; fg = Theme.Secondary; break;
                case BadgeKind.Primary: bg = Theme.Primary; fg = Theme.OnPrimary; break;
                default: bg = Theme.SurfaceHigh; fg = Theme.OnSurface; break;
            }
            UiHelpers.FillRounded(e.Graphics, bg, ClientRectangle, _radius);
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, fg,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
        }
    }
}
