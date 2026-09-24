using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using RestauranteGestor.Services;
using RestauranteGestor.Theme;

namespace RestauranteGestor
{
    public partial class Form1 : Form
    {
        private WebView2 webView;
        private Timer clockTimer;
        private Label lblClock;
        private ModuleStore store;
        private Bridge bridge;

        public Form1()
        {
            InitializeComponent();
            InitRestoOS();
        }

        private void InitRestoOS()
        {
            this.Text = "RestoOS - Modular Core | Escalabilidad";
            this.BackColor = AppColors.Surface;
            this.MinimumSize = new Size(1280, 720);
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            store = new ModuleStore();
            bridge = new Bridge(store);

            // Sidebar + TopBar ya creados en Designer, solo agregar WebView2 al panel principal
            if (panelMain != null)
            {
                webView = new WebView2();
                webView.Dock = DockStyle.Fill;
                panelMain.Controls.Add(webView);
                webView.BringToFront();
                webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
                webView.NavigationCompleted += WebView_NavigationCompleted;
                InitWebViewAsync();
            }

            // reloj
            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) => UpdateClock();
            clockTimer.Start();
            UpdateClock();

            // handlers botones sidebar + topbar gear (buscar recursivo porque navHost contiene botones)
            AttachSidebarHandlers(sidebarPanel);
            AttachSidebarHandlers(panelTop);
        }

        private void UpdateClock()
        {
            if (lblClock != null) lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private async void InitWebViewAsync()
        {
            try
            {
                await webView.EnsureCoreWebView2Async(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebView2 no pudo inicializar: " + ex.Message + "\nInstala Microsoft Edge WebView2 Runtime.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess) return;
            try
            {
                webView.CoreWebView2.AddHostObjectToScript("bridge", bridge);
                webView.CoreWebView2.Settings.AreDevToolsEnabled = true;
                var htmlPath = Path.Combine(Application.StartupPath, "Assets", "web", "index.html");
                if (!File.Exists(htmlPath))
                {
                    // fallback development path
                    htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "web", "index.html");
                    htmlPath = Path.GetFullPath(htmlPath);
                }
                if (File.Exists(htmlPath))
                    webView.CoreWebView2.Navigate(new Uri(htmlPath).AbsoluteUri);
                else
                    webView.CoreWebView2.NavigateToString("<h1 style='color:white;background:#111415;padding:40px'>No se encontr\u00f3 Assets/web/index.html<br>" + htmlPath + "</h1>");
            }
            catch { }
        }

        private void WebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            // opcional: inyectar estado inicial si localStorage vacio
        }

        private void AttachSidebarHandlers(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button b) b.Click += SidebarButton_Click;
                if (c.HasChildren) AttachSidebarHandlers(c);
            }
        }

        private void ClearSidebarSelection(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button b) { b.BackColor = AppColors.SurfaceContainerLowest; b.ForeColor = AppColors.OnSurface; }
                if (c.HasChildren) ClearSidebarSelection(c);
            }
        }

        private void NavigateToModulos()
        {
            try
            {
                var htmlPath = Path.Combine(Application.StartupPath, "Assets", "web", "index.html");
                if (!File.Exists(htmlPath))
                    htmlPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "web", "index.html"));
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.Visible = true;
                    webView.CoreWebView2.Navigate(new Uri(htmlPath).AbsoluteUri);
                    // scroll al grid de módulos tras cargar
                    webView.CoreWebView2.ExecuteScriptAsync("try{window.scrollTo({top:0,behavior:'smooth'}); var t=setTimeout(()=>{var g=document.querySelector('.grid'); if(g) g.scrollIntoView({behavior:'smooth',block:'start'});},400);}catch(e){}");
                }
            }
            catch { }
        }

        private void NavigateToPos()
        {
            try
            {
                var htmlPath = Path.Combine(Application.StartupPath, "Assets", "web", "pos.html");
                if (!File.Exists(htmlPath))
                    htmlPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "web", "pos.html"));
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.Visible = true;
                    if (File.Exists(htmlPath))
                        webView.CoreWebView2.Navigate(new Uri(htmlPath).AbsoluteUri);
                    else
                        webView.CoreWebView2.NavigateToString("<h1 style='color:white;background:#111415;padding:40px'>No se encontró Assets/web/pos.html<br>" + htmlPath + "</h1>");
                }
            }
            catch { }
        }

        private void NavigateToMesas()
        {
            try
            {
                var htmlPath = Path.Combine(Application.StartupPath, "Assets", "web", "mesas.html");
                if (!File.Exists(htmlPath))
                    htmlPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "web", "mesas.html"));
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.Visible = true;
                    if (File.Exists(htmlPath))
                        webView.CoreWebView2.Navigate(new Uri(htmlPath).AbsoluteUri);
                    else
                        webView.CoreWebView2.NavigateToString("<h1 style='color:white;background:#111415;padding:40px'>No se encontró Assets/web/mesas.html<br>" + htmlPath + "</h1>");
                }
            }
            catch { }
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            var tag = btn.Tag != null ? btn.Tag.ToString() : "";

            // rueda de configuración -> abre apartado de módulos
            if (tag == "config-modulos")
            {
                ClearSidebarSelection(sidebarPanel);
                btn.BackColor = AppColors.SurfaceContainerHigh;
                btn.ForeColor = AppColors.Primary;
                // resaltar también el Selector de Módulos como activo
                foreach (Control cc in GetAllControls(sidebarPanel))
                    if (cc is Button bb && bb.Tag != null && bb.Tag.ToString() == "selector") { bb.BackColor = AppColors.SurfaceContainerHigh; bb.ForeColor = AppColors.Primary; }
                NavigateToModulos();
                return;
            }

            // resaltar seleccionado
            ClearSidebarSelection(sidebarPanel);
            btn.BackColor = AppColors.SurfaceContainerHigh;
            btn.ForeColor = AppColors.Primary;

            if (tag == "selector")
            {
                NavigateToModulos();
            }
            else if (tag == "pos")
            {
                NavigateToPos();
            }
            else if (tag == "mesas")
            {
                NavigateToMesas();
            }
            else
            {
                var name = btn.Text.Trim();
                webView.CoreWebView2?.NavigateToString($"<html style='background:#191c1e;color:#e1e2e4;font-family:Segoe UI;display:flex;align-items:center;justify-content:center;height:100vh'><h1>{name} — próximamente</h1></html>");
            }
        }

        private void SelectNavButton(string tag)
        {
            ClearSidebarSelection(sidebarPanel);
            foreach (Control cc in GetAllControls(sidebarPanel))
                if (cc is Button bb && bb.Tag != null && bb.Tag.ToString() == tag) { bb.BackColor = AppColors.SurfaceContainerHigh; bb.ForeColor = AppColors.Primary; }
        }

        private System.Collections.Generic.IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                yield return c;
                foreach (var ch in GetAllControls(c)) yield return ch;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1) { SelectNavButton("pos"); NavigateToPos(); return true; }
            if (keyData == Keys.F2) { SelectNavButton("mesas"); NavigateToMesas(); return true; }
            if (keyData == Keys.F2) { /* Mesas */ return true; }
            if (keyData == Keys.F3) { /* KDS */ return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
