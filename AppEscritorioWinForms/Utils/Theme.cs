using System.Drawing;

namespace app_escritorio.Utils
{
    public static class Theme
    {
        // Base (paridad con tema WPF: Surface)
        public static readonly Color BackgroundDark = Color.FromArgb(17, 20, 21);       // #111415
        public static readonly Color BackgroundMedium = Color.FromArgb(29, 32, 34);     // #1D2022
        public static readonly Color BackgroundLight = Color.FromArgb(40, 42, 44);      // #282A2C

        // Acentos (paridad WPF)
        public static readonly Color AccentPrimary = Color.FromArgb(240, 101, 54);      // #F06536
        public static readonly Color AccentSecondary = Color.FromArgb(78, 222, 163);    // #4EDEA3
        public static readonly Color AccentWarning = Color.FromArgb(255, 185, 95);      // #FFB95F

        // Texto (paridad WPF)
        public static readonly Color TextPrimary = Color.FromArgb(225, 226, 228);       // #E1E2E4
        public static readonly Color TextSecondary = Color.FromArgb(225, 191, 181);     // #E1BFB5
        public static readonly Color TextMuted = Color.FromArgb(225, 191, 181);         // #E1BFB5
        public static readonly Color TertiaryText = Color.FromArgb(0, 56, 36);          // #003824 (texto sobre verde)
        public static readonly Color DangerBackground = Color.FromArgb(46, 26, 26);     // #2E1A1A (fondo peligro)

        // Estado (paridad WPF)
        public static readonly Color StatusAvailable = Color.FromArgb(78, 222, 163);    // #4EDEA3
        public static readonly Color StatusUnavailable = Color.FromArgb(255, 180, 171); // #FFB4AB
        public static readonly Color StatusWarning = Color.FromArgb(255, 185, 95);      // #FFB95F

        // Botones estilo app (paridad con PrimaryButton del tema WPF: melocotón + texto oscuro)
        public static readonly Color ButtonPrimary = Color.FromArgb(255, 181, 157);
        public static readonly Color ButtonPrimaryText = Color.FromArgb(93, 24, 0);

        // Bordes (paridad WPF)
        public static readonly Color BorderLight = Color.FromArgb(89, 65, 58);          // #59413A
        public static readonly Color BorderDark = Color.FromArgb(12, 15, 16);           // #0C0F10

        // Fonts
        public static Font FontPrimary => new Font("Segoe UI", 10F, FontStyle.Regular);
        public static Font FontPrimaryBold => new Font("Segoe UI", 10F, FontStyle.Bold);
        public static Font FontTitle => new Font("Segoe UI", 14F, FontStyle.Bold);
        public static Font FontSubtitle => new Font("Segoe UI", 11F, FontStyle.Bold);
        public static Font FontSmall => new Font("Segoe UI", 8F, FontStyle.Regular);
        public static Font FontLarge => new Font("Segoe UI", 12F, FontStyle.Bold);
    }
}
