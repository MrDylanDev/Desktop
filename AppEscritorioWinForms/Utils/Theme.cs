using System.Drawing;

namespace app_escritorio.Utils
{
    public static class Theme
    {
        // Base colors (dark mode inspired by modern restaurant UIs)
        public static readonly Color BackgroundDark = Color.FromArgb(30, 30, 30);      // #1e1e1e
        public static readonly Color BackgroundMedium = Color.FromArgb(50, 50, 50);    // #323232
        public static readonly Color BackgroundLight = Color.FromArgb(70, 70, 70);     // #464646

        // Accent colors
        public static readonly Color AccentPrimary = Color.FromArgb(255, 107, 53);     // Orange/Gold
        public static readonly Color AccentSecondary = Color.FromArgb(76, 175, 80);    // Green
        public static readonly Color AccentWarning = Color.FromArgb(255, 152, 0);      // Amber

        // Text colors
        public static readonly Color TextPrimary = Color.White;
        public static readonly Color TextSecondary = Color.FromArgb(200, 200, 200);    // Light gray
        public static readonly Color TextMuted = Color.FromArgb(140, 140, 140);        // Muted gray

        // Status colors
        public static readonly Color StatusAvailable = Color.FromArgb(76, 175, 80);    // Green
        public static readonly Color StatusUnavailable = Color.FromArgb(244, 67, 54);  // Red
        public static readonly Color StatusWarning = Color.FromArgb(255, 152, 0);      // Orange

        // Border colors
        public static readonly Color BorderLight = Color.FromArgb(80, 80, 80);
        public static readonly Color BorderDark = Color.FromArgb(40, 40, 40);

        // Fonts
        public static Font FontPrimary => new Font("Segoe UI", 10F, FontStyle.Regular);
        public static Font FontPrimaryBold => new Font("Segoe UI", 10F, FontStyle.Bold);
        public static Font FontTitle => new Font("Segoe UI", 14F, FontStyle.Bold);
        public static Font FontSubtitle => new Font("Segoe UI", 11F, FontStyle.Bold);
        public static Font FontSmall => new Font("Segoe UI", 8F, FontStyle.Regular);
        public static Font FontLarge => new Font("Segoe UI", 12F, FontStyle.Bold);
    }
}
