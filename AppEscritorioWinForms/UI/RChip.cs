using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>Estilo de <see cref="RChip"/>.</summary>
    public enum ChipStyle
    {
        /// <summary>Sin fondo (se resalta al pasar el mouse o si está seleccionado). Contadores de la barra.</summary>
        Plain,
        /// <summary>Fondo suave del color de acento. Categorías, filtros.</summary>
        Soft,
        /// <summary>Solo borde del color de acento. Etiquetas de platos (Sin TACC, Vegetariano...).</summary>
        Outline,
        /// <summary>Relleno del color de acento con texto oscuro. Estados (DISPONIBLE).</summary>
        Solid
    }

    /// <summary>
    /// Chip / etiqueta: ícono + texto con forma de píldora. Puede ser un filtro seleccionable
    /// (<see cref="Clickable"/> + <see cref="Selected"/>) o una etiqueta fija.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("Click")]
    [Description("Chip / etiqueta temática RestoOS.")]
    public class RChip : Control
    {
        private string _glyph = "";
        private Color _accent = Color.Empty;
        private ChipStyle _style = ChipStyle.Soft;
        private bool _selected, _clickable, _hover, _small;

        public RChip()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            base.Font = Theme.GetFont(9F, FontStyle.Bold);
            Size = new Size(120, 28);
            Margin = new Padding(0, 0, 8, 6);
        }

        [Category("RestoOS"), DefaultValue(""), Description("Ícono antes del texto (✓, ☆, ●...).")]
        public string Glyph { get => _glyph; set { _glyph = value ?? ""; FitWidth(); Invalidate(); } }

        [Category("RestoOS"), Description("Color del chip. Vacío = gris.")]
        public Color AccentColor { get => _accent; set { _accent = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(ChipStyle.Soft)]
        public ChipStyle ChipStyle { get => _style; set { _style = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(false), Description("Resaltado como filtro activo.")]
        public bool Selected { get => _selected; set { _selected = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(false), Description("Muestra la mano y el resaltado al pasar el mouse.")]
        public bool Clickable
        {
            get => _clickable;
            set { _clickable = value; Cursor = value ? Cursors.Hand : Cursors.Default; }
        }

        [Category("RestoOS"), DefaultValue(false), Description("Texto más pequeño (etiquetas dentro de tarjetas).")]
        public bool Small
        {
            get => _small;
            set { _small = value; base.Font = Theme.GetFont(value ? 8F : 9F, FontStyle.Bold); FitWidth(); Invalidate(); }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => base.Text; set { base.Text = value; FitWidth(); Invalidate(); } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get => base.Font; set { } }

        private string Caption => _glyph.Length > 0 ? _glyph + "  " + Text : Text;

        /// <summary>El ancho se ajusta solo al texto.</summary>
        public override Size GetPreferredSize(Size proposedSize)
        {
            var sz = TextRenderer.MeasureText(Caption, Font, Size.Empty, TextFormatFlags.NoPadding);
            return new Size(sz.Width + (_small ? 18 : 24), Height);
        }

        private void FitWidth()
        {
            if (IsHandleCreated || Parent != null) Width = GetPreferredSize(Size.Empty).Width;
        }

        protected override void OnParentChanged(EventArgs e) { base.OnParentChanged(e); FitWidth(); }
        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); _hover = true; Invalidate(); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); _hover = false; Invalidate(); }

        protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));

        protected override void OnPaint(PaintEventArgs e)
        {
            var bg = UiHelpers.EffectiveBackColor(this);
            var accent = _accent.IsEmpty ? Theme.OnSurfaceVariant : _accent;
            var r = new Rectangle(0, 0, Width - 1, Height - 1);
            int radius = Height / 2;
            Color fg = accent;
            bool hot = _clickable && _hover;

            switch (_style)
            {
                case ChipStyle.Solid:
                    UiHelpers.FillRounded(e.Graphics, accent, r, radius);
                    fg = Theme.Surface;
                    break;
                case ChipStyle.Outline:
                    if (_selected || hot) UiHelpers.FillRounded(e.Graphics, Theme.Blend(accent, bg, 0.12), r, radius);
                    UiHelpers.DrawRounded(e.Graphics, Theme.Blend(accent, bg, _selected ? 0.9 : 0.55), r, radius, 1f);
                    if (_accent.IsEmpty) fg = Theme.OnSurface;
                    break;
                case ChipStyle.Plain:
                    if (_selected || hot) UiHelpers.FillRounded(e.Graphics, Theme.Blend(accent, bg, _selected ? 0.18 : 0.1), r, radius);
                    if (_selected) UiHelpers.DrawRounded(e.Graphics, Theme.Blend(accent, bg, 0.6), r, radius, 1f);
                    break;
                default: // Soft
                    UiHelpers.FillRounded(e.Graphics, Theme.Blend(accent, bg, _selected ? 0.28 : hot ? 0.2 : 0.13), r, radius);
                    if (_selected) UiHelpers.DrawRounded(e.Graphics, Theme.Blend(accent, bg, 0.8), r, radius, 1f);
                    break;
            }

            if (_style == ChipStyle.Plain && _glyph.Length > 0)
            {
                // Ícono del color de acento y texto claro (contadores de la barra superior)
                var gSize = TextRenderer.MeasureText(_glyph + "  ", Font, Size.Empty, TextFormatFlags.NoPadding);
                int total = TextRenderer.MeasureText(Caption, Font, Size.Empty, TextFormatFlags.NoPadding).Width;
                int x = (Width - total) / 2;
                TextRenderer.DrawText(e.Graphics, _glyph, Font, new Rectangle(x, 0, gSize.Width, Height), accent,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
                TextRenderer.DrawText(e.Graphics, Text, Font, new Rectangle(x + gSize.Width, 0, Width, Height), Theme.OnSurface,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
                return;
            }
            TextRenderer.DrawText(e.Graphics, Caption, Font, ClientRectangle, fg,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }
    }
}
