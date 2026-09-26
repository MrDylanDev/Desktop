using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace app_escritorio.UI
{
    /// <summary>Superficies de la paleta (equivalen a los brushes de App.xaml).</summary>
    public enum SurfaceLevel { Transparent, Surface, Lowest, Container, High, Highest }

    /// <summary>Controles que pintan un fondo propio (tarjetas de producto, líneas de ticket...).</summary>
    public interface ISurfaceProvider { Color SurfaceColor { get; } }

    internal static class UiHelpers
    {
        /// <summary>true cuando el código corre dentro del diseñador de Visual Studio.</summary>
        public static bool IsDesignTime => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public static Color ColorOf(SurfaceLevel level)
        {
            switch (level)
            {
                case SurfaceLevel.Surface: return Utils.Theme.Surface;
                case SurfaceLevel.Lowest: return Utils.Theme.SurfaceLowest;
                case SurfaceLevel.Container: return Utils.Theme.SurfaceContainer;
                case SurfaceLevel.High: return Utils.Theme.SurfaceHigh;
                case SurfaceLevel.Highest: return Utils.Theme.SurfaceHighest;
                default: return Color.Transparent;
            }
        }

        public static GraphicsPath RoundedRect(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0.5f || r.Width <= 0 || r.Height <= 0)
            {
                path.AddRectangle(r);
                return path;
            }
            float d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void FillRounded(Graphics g, Color color, Rectangle bounds, int radius)
        {
            if (color.A == 0) return;
            var old = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = RoundedRect(new RectangleF(bounds.X, bounds.Y, bounds.Width - 0.5f, bounds.Height - 0.5f), radius))
            using (var brush = new SolidBrush(color))
                g.FillPath(brush, path);
            g.SmoothingMode = old;
        }

        public static void DrawRounded(Graphics g, Color color, Rectangle bounds, int radius, float width = 1f)
        {
            var old = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = RoundedRect(new RectangleF(bounds.X + width / 2, bounds.Y + width / 2, bounds.Width - width - 0.5f, bounds.Height - width - 0.5f), radius))
            using (var pen = new Pen(color, width))
                g.DrawPath(pen, path);
            g.SmoothingMode = old;
        }

        /// <summary>Primer color de fondo opaco hacia arriba en la jerarquía (para esquinas y mezclas).</summary>
        public static Color EffectiveBackColor(Control c)
        {
            for (var p = c?.Parent; p != null; p = p.Parent)
            {
                if (p is RPanel rp)
                {
                    if (rp.Surface != SurfaceLevel.Transparent) return ColorOf(rp.Surface);
                    continue;
                }
                if (p is ISurfaceProvider sp && sp.SurfaceColor.A == 255) return sp.SurfaceColor;
                if (p.BackColor.A == 255) return p.BackColor;
            }
            return Utils.Theme.Surface;
        }

        // ===== Detalles nativos: barra de título y scrollbars oscuros (Windows 10 1809+ / 11) =====
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        public static void ApplyDarkTitleBar(Form form)
        {
            if (IsDesignTime || form == null || !form.IsHandleCreated) return;
            try
            {
                int on = 1;
                if (DwmSetWindowAttribute(form.Handle, 20, ref on, sizeof(int)) != 0)
                    DwmSetWindowAttribute(form.Handle, 19, ref on, sizeof(int));
            }
            catch { /* Windows sin DWM moderno: se queda la barra clara */ }
        }

        public static void ApplyDarkScrollbars(Control c)
        {
            if (IsDesignTime || c == null || !c.IsHandleCreated) return;
            try { SetWindowTheme(c.Handle, "DarkMode_Explorer", null); } catch { }
        }
    }
}
