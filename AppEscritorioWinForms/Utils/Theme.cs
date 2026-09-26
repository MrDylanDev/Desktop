using System.Collections.Generic;
using System.Drawing;

namespace app_escritorio.Utils
{
    /// <summary>
    /// Paleta y tipografía únicas de RestoOS, copiadas 1:1 de App.xaml de la versión WPF.
    /// Los controles de app_escritorio.UI leen de aquí: si cambias un color, cambia en toda la app.
    /// </summary>
    public static class Theme
    {
        // ===== Paleta WPF (mismos nombres que App.xaml) =====
        public static readonly Color Surface = ColorTranslator.FromHtml("#111415");
        public static readonly Color SurfaceLowest = ColorTranslator.FromHtml("#0C0F10");
        public static readonly Color SurfaceContainer = ColorTranslator.FromHtml("#1D2022");
        public static readonly Color SurfaceHigh = ColorTranslator.FromHtml("#282A2C");
        public static readonly Color SurfaceHighest = ColorTranslator.FromHtml("#333537");
        public static readonly Color OnSurface = ColorTranslator.FromHtml("#E1E2E4");
        public static readonly Color OnSurfaceVariant = ColorTranslator.FromHtml("#E1BFB5");
        public static readonly Color Primary = ColorTranslator.FromHtml("#FFB59D");
        public static readonly Color OnPrimary = ColorTranslator.FromHtml("#5D1800");
        public static readonly Color PrimaryContainer = ColorTranslator.FromHtml("#F06536");
        public static readonly Color Secondary = ColorTranslator.FromHtml("#FFB95F");
        public static readonly Color Tertiary = ColorTranslator.FromHtml("#4EDEA3");
        public static readonly Color OnTertiary = ColorTranslator.FromHtml("#003824");
        public static readonly Color Error = ColorTranslator.FromHtml("#FFB4AB");
        public static readonly Color ErrorContainer = ColorTranslator.FromHtml("#2E1A1A");
        public static readonly Color ErrorContainerHover = ColorTranslator.FromHtml("#4A2424");
        public static readonly Color Outline = ColorTranslator.FromHtml("#59413A");

        // ===== Alias usados por el código existente (Form1, OrderForm, MenuCard...) =====
        public static readonly Color BackgroundDark = Surface;
        public static readonly Color BackgroundMedium = SurfaceContainer;
        public static readonly Color BackgroundLight = SurfaceHigh;
        public static readonly Color AccentPrimary = PrimaryContainer;
        public static readonly Color AccentSecondary = Tertiary;
        public static readonly Color AccentWarning = Secondary;
        public static readonly Color TextPrimary = OnSurface;
        public static readonly Color TextSecondary = OnSurfaceVariant;
        public static readonly Color TextMuted = OnSurfaceVariant;
        public static readonly Color TertiaryText = OnTertiary;
        public static readonly Color DangerBackground = ErrorContainer;
        public static readonly Color StatusAvailable = Tertiary;
        public static readonly Color StatusUnavailable = Error;
        public static readonly Color StatusWarning = Secondary;
        public static readonly Color ButtonPrimary = Primary;
        public static readonly Color ButtonPrimaryText = OnPrimary;
        public static readonly Color BorderLight = Outline;
        public static readonly Color BorderDark = SurfaceLowest;

        // ===== Tipografía (cacheada: no crea un Font nuevo en cada uso) =====
        public const string FontFamilyName = "Segoe UI";
        private static readonly Dictionary<string, Font> _fonts = new Dictionary<string, Font>();

        /// <summary>Devuelve una fuente compartida. No la hagas Dispose.</summary>
        public static Font GetFont(float sizePt, FontStyle style = FontStyle.Regular, string family = FontFamilyName)
        {
            string key = family + "|" + sizePt + "|" + (int)style;
            lock (_fonts)
            {
                if (!_fonts.TryGetValue(key, out var f))
                {
                    f = new Font(family, sizePt, style, GraphicsUnit.Point);
                    _fonts[key] = f;
                }
                return f;
            }
        }

        public static Font FontPrimary => GetFont(10F);
        public static Font FontPrimaryBold => GetFont(10F, FontStyle.Bold);
        public static Font FontTitle => GetFont(14F, FontStyle.Bold);
        public static Font FontSubtitle => GetFont(11F, FontStyle.Bold);
        public static Font FontSmall => GetFont(8F);
        public static Font FontLarge => GetFont(12F, FontStyle.Bold);

        /// <summary>Mezcla un color con el fondo (para simular Opacity de WPF).</summary>
        public static Color Blend(Color fg, Color bg, double opacity)
        {
            return Color.FromArgb(
                (int)(fg.R * opacity + bg.R * (1 - opacity)),
                (int)(fg.G * opacity + bg.G * (1 - opacity)),
                (int)(fg.B * opacity + bg.B * (1 - opacity)));
        }
    }
}
