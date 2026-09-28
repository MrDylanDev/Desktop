using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Views.Carta
{
    /// <summary>
    /// Foto del plato (recortada para llenar, con esquinas superiores redondeadas) y las etiquetas encima:
    /// destacado (★ Plato Más Vendido), estado (● DISPONIBLE / ⚠ AGOTADO HOY) y categoría.
    /// Sin foto dibuja un fondo cálido con un ícono.
    /// </summary>
    [ToolboxItem(true)]
    [Description("Foto de plato con etiquetas (Menú digital).")]
    public class DishImage : Control
    {
        private static readonly Dictionary<string, Image> Cache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        private Image _image;
        private string _statusText = "● DISPONIBLE", _categoryText = "", _highlightText = "", _glyph = "🍽";
        private Color _statusColor = Theme.Tertiary;
        private bool _dimmed, _roundBottom;
        private int _radius = 14;

        public DishImage()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            Size = new Size(300, 150);
        }

        /// <summary>Carga una imagen desde disco sin bloquear el archivo (con caché). Devuelve null si no existe.</summary>
        public static Image LoadCached(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            if (Cache.TryGetValue(path, out var img)) return img;
            try
            {
                if (!File.Exists(path)) return null;
                using (var src = Image.FromFile(path)) img = new Bitmap(src);
                Cache[path] = img;
                return img;
            }
            catch { return null; }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image { get => _image; set { _image = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue("● DISPONIBLE")]
        public string StatusText { get => _statusText; set { _statusText = value ?? ""; Invalidate(); } }

        [Category("RestoOS")]
        public Color StatusColor { get => _statusColor; set { _statusColor = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(""), Description("Etiqueta oscura (categoría o sello: Carnes Grill, Horno de Barro...).")]
        public string CategoryText { get => _categoryText; set { _categoryText = value ?? ""; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(""), Description("Sello dorado (★ Plato Más Vendido).")]
        public string HighlightText { get => _highlightText; set { _highlightText = value ?? ""; Invalidate(); } }

        [Category("RestoOS"), DefaultValue("🍽"), Description("Ícono cuando no hay foto.")]
        public string Glyph { get => _glyph; set { _glyph = value ?? ""; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(false), Description("Oscurece la foto (plato pausado o agotado).")]
        public bool Dimmed { get => _dimmed; set { _dimmed = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(14)]
        public int CornerRadius { get => _radius; set { _radius = Math.Max(0, value); Invalidate(); } }

        [Category("RestoOS"), DefaultValue(false), Description("Redondea también las esquinas de abajo (vista previa del editor).")]
        public bool RoundBottom { get => _roundBottom; set { _roundBottom = value; Invalidate(); } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        private GraphicsPath Shape()
        {
            var r = new Rectangle(0, 0, Width, Height);
            int d = _radius * 2;
            var p = new GraphicsPath();
            if (_radius == 0) { p.AddRectangle(r); return p; }
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d - 1, r.Y, d, d, 270, 90);
            if (_roundBottom)
            {
                p.AddArc(r.Right - d - 1, r.Bottom - d - 1, d, d, 0, 90);
                p.AddArc(r.X, r.Bottom - d - 1, d, d, 90, 90);
            }
            else
            {
                p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            }
            p.CloseFigure();
            return p;
        }

        protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (var shape = Shape())
            {
                g.SetClip(shape);
                if (_image != null) DrawCover(g, _image);
                else DrawPlaceholder(g);

                // Sombra arriba para que se lean las etiquetas
                using (var top = new LinearGradientBrush(new Rectangle(0, 0, Width, 60), Color.FromArgb(120, 0, 0, 0), Color.FromArgb(0, 0, 0, 0), 90f))
                    g.FillRectangle(top, 0, 0, Width, 60);
                if (_dimmed)
                    using (var dim = new SolidBrush(Color.FromArgb(150, Theme.SurfaceLowest)))
                        g.FillRectangle(dim, ClientRectangle);
                g.ResetClip();
            }

            // Etiquetas encima de la foto
            int x = 10;
            var font = Theme.GetFont(8F, FontStyle.Bold);
            if (_highlightText.Length > 0) x = Pill(g, "★ " + _highlightText, font, x, Theme.Secondary, Theme.Surface) + 6;
            if (_statusText.Length > 0) x = Pill(g, _statusText, font, x, _statusColor, Theme.Surface) + 6;
            if (_categoryText.Length > 0) Pill(g, _categoryText, font, x, Color.FromArgb(215, Theme.Surface), Theme.OnSurface);
        }

        private int Pill(Graphics g, string text, Font font, int x, Color fill, Color fg)
        {
            var sz = TextRenderer.MeasureText(text, font, Size.Empty, TextFormatFlags.NoPadding);
            int w = Math.Min(sz.Width + 16, Math.Max(0, Width - x - 10));
            if (w < 24) return x;
            var r = new Rectangle(x, 10, w, 22);
            UiHelpers.FillRounded(g, fill, r, 11);
            TextRenderer.DrawText(g, text, font, r, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                                                          TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
            return r.Right;
        }

        private void DrawCover(Graphics g, Image img)
        {
            float scale = Math.Max((float)Width / img.Width, (float)Height / img.Height);
            float w = img.Width * scale, h = img.Height * scale;
            g.DrawImage(img, (Width - w) / 2f, (Height - h) / 2f, w, h);
        }

        private void DrawPlaceholder(Graphics g)
        {
            using (var brush = new LinearGradientBrush(ClientRectangle.Width > 0 ? ClientRectangle : new Rectangle(0, 0, 1, 1),
                       Theme.Blend(Theme.PrimaryContainer, Theme.SurfaceLowest, 0.38), Theme.SurfaceLowest, 60f))
                g.FillRectangle(brush, ClientRectangle);
            if (_glyph.Length == 0) return;
            var font = Theme.GetFont(Math.Max(18F, Height / 4.2F), FontStyle.Regular, "Segoe UI Emoji");
            TextRenderer.DrawText(g, _glyph, font, new Rectangle(0, 14, Width, Height - 14),
                Theme.Blend(Theme.Primary, Theme.SurfaceLowest, 0.55), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
