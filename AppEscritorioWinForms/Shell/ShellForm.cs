using System;
using System.Collections.Generic;
using System.Windows.Forms;
using app_escritorio.Controls;
using app_escritorio.Data;
using app_escritorio.Forms;
using app_escritorio.UI;
using app_escritorio.Views.Mesas;
using app_escritorio.Views.Pos;

namespace app_escritorio.Shell
{
    /// <summary>
    /// Ventana principal única (equivale a MainWindow de WPF): sidebar + barra superior + área de contenido.
    /// Cada módulo es un UserControl que se crea una vez y se intercambia en <c>contentHost</c>.
    /// Los módulos que todavía no se migraron (KDS, Inventario, Reservas, Delivery, Menú, Módulos, Reportes, Configuración) se muestran con <see cref="HostLegacyForm"/>.
    /// </summary>
    public partial class ShellForm : Form
    {
        private readonly string _role = "Admin";
        private readonly Dictionary<string, Control> _views = new Dictionary<string, Control>();
        private string _currentRoute;

        /// <summary>true si el usuario pulsó "Cambiar perfil" (Program vuelve a mostrar el login).</summary>
        public bool ChangeProfileRequested { get; private set; }

        public ShellForm() : this("Admin") { }

        public ShellForm(string role)
        {
            _role = string.IsNullOrWhiteSpace(role) ? "Admin" : role;
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            bool isAdmin = IsAdmin;
            topBar.RoleText = isAdmin ? "Administrador" : "Empleados";
            sidebar.SetRole(isAdmin);
            sidebar.SetBranch(LocalSettings.LoadRestaurantName(), LocalSettings.LoadAddress());

            foreach (var module in new[] { "salon", "menu", "kds", "inventario", "reservas", "delivery", "reportes" })
                sidebar.SetModuleEnabled(module, LocalSettings.IsModuleEnabled(module));
            ModulesForm.ModuleStateChanged += ModulesForm_ModuleStateChanged;

            Navigate(isAdmin ? "modulos" : "pos");
        }

        private bool IsAdmin => _role == "Admin" || _role == "Administrador";

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UiHelpers.ApplyDarkTitleBar(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ModulesForm.ModuleStateChanged -= ModulesForm_ModuleStateChanged;
            base.OnFormClosed(e);
        }

        // ===================== Navegación =====================

        private void Sidebar_NavigateRequested(object sender, NavigateEventArgs e) => Navigate(e.Route);

        private void TopBar_CambiarPerfilClicked(object sender, EventArgs e)
        {
            ChangeProfileRequested = true;
            Close();
        }

        /// <summary>Atajos F1 POS · F2 Mesas · F3 KDS (anunciados en el sidebar).</summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string route = keyData == Keys.F1 ? "pos" : keyData == Keys.F2 ? "mesas" : keyData == Keys.F3 ? "kds" : null;
            if (route != null && sidebar.IsRouteAvailable(route))
            {
                Navigate(route);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void Navigate(string route)
        {
            route = (route ?? "modulos").ToLowerInvariant();

            if ((route == "reportes" || route == "configuracion") && !IsAdmin)
            {
                MessageBox.Show(route == "reportes" ? "Solo el Administrador puede ver Reportes." : "Solo el Administrador puede ver Configuración.",
                    "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var view = GetOrCreateView(route);
            if (view == null) return;

            contentHost.SuspendLayout();
            foreach (Control c in contentHost.Controls)
                if (c != view) c.Visible = false;
            if (!contentHost.Controls.Contains(view)) contentHost.Controls.Add(view);
            view.Visible = true;
            view.BringToFront();
            contentHost.ResumeLayout(true);

            OnViewShown(route, view);
            _currentRoute = route;
            topBar.RouteText = RouteTitle(route);
            sidebar.SetActive(route);
        }

        private static string RouteTitle(string route)
        {
            switch (route)
            {
                case "pos": return "POS";
                case "mesas": return "Mesas y Salón";
                case "kds": return "Cocina KDS · DEMO";
                case "inventario": return "Inventario · DEMO";
                case "reservas": return "Reservas · DEMO";
                case "delivery": return "Delivery · DEMO";
                case "reportes": return "Reportes · Solo Admin";
                case "configuracion": return "Configuración · Solo Admin";
                case "menu": return "Menú y productos";
                default: return "Módulos";
            }
        }

        private Control GetOrCreateView(string route)
        {
            if (_views.TryGetValue(route, out var existing)) return existing;

            Control view;
            switch (route)
            {
                case "pos":
                    view = new PosView();
                    break;
                case "mesas":
                    var mesas = new MesasView();
                    mesas.MesaParaPos += ShowPosForTable;
                    view = mesas;
                    break;
                case "kds": view = HostLegacyForm(new KdsForm { Role = _role }); break;
                case "inventario": view = HostLegacyForm(new InventarioForm { Role = _role }); break;
                case "reservas": view = HostLegacyForm(new ReservasForm { Role = _role }); break;
                case "delivery": view = HostLegacyForm(new DeliveryForm { Role = _role }); break;
                case "reportes": view = HostLegacyForm(new ReportesForm { Role = _role }); break;
                case "configuracion": view = HostLegacyForm(new SettingsForm { Role = _role }); break;
                case "menu": view = HostLegacyForm(new Form1 { Role = _role }); break;
                default:
                    route = "modulos";
                    if (_views.TryGetValue(route, out existing)) return existing;
                    view = HostLegacyForm(new ModulesForm { Role = _role });
                    break;
            }
            view.Dock = DockStyle.Fill;
            _views[route] = view;
            return view;
        }

        private void OnViewShown(string route, Control view)
        {
            if (view is PosView pos) pos.ReloadTax();

            if (view is MesasView mesas) mesas.RefreshView();
        }

        private void ShowPosForTable(string mesa)
        {
            var pos = (PosView)GetOrCreateView("pos");
            pos.SetMesa(mesa);
            Navigate("pos");
        }

        private void ModulesForm_ModuleStateChanged(string module, bool enabled)
        {
            sidebar.SetModuleEnabled(module, enabled);
            if (enabled) return;
            string route = module == "salon" ? "mesas" : module;
            if (_currentRoute == route) Navigate("modulos");
        }

        /// <summary>
        /// Muestra dentro de la ventana principal un formulario viejo (con su propio sidebar/topbar),
        /// ocultando esas barras duplicadas. Se usa mientras cada módulo se migra a UserControl.
        /// </summary>
        private static Control HostLegacyForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            foreach (Control c in form.Controls)
                if (c is SidebarControl || c is TopBarControl) c.Visible = false;

            var host = new RPanel { Surface = SurfaceLevel.Surface, Dock = DockStyle.Fill };
            host.Controls.Add(form);
            form.Show();
            return host;
        }
    }
}
