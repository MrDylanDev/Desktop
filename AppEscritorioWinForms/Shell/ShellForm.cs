using System;
using System.Collections.Generic;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Forms;
using app_escritorio.UI;

namespace app_escritorio.Shell
{
    /// <summary>
    /// Ventana principal única (equivale a MainWindow de WPF): sidebar + barra superior + área de contenido.
    /// Cada sección es un Form de Forms/* (PosForm, MesasForm, KdsForm...). En el diseñador cada uno se ve con la app completa;
    /// aquí se crea una vez, se le quitan su sidebar y su barra superior y se muestra dentro de <c>contentHost</c> (ver <see cref="HostSectionForm"/>).
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

            foreach (var module in ModuleStore.Keys)
                sidebar.SetModuleEnabled(module, ModuleStore.IsEnabled(module));
            ModuleStore.ModuleStateChanged += ModuleStore_ModuleStateChanged;

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
            ModuleStore.ModuleStateChanged -= ModuleStore_ModuleStateChanged;
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

            Form form;
            switch (route)
            {
                case "pos": form = new PosForm(); break;
                case "mesas":
                    var mesas = new MesasForm();
                    mesas.MesaParaPos += ShowPosForTable;
                    form = mesas;
                    break;
                case "kds": form = new KdsForm(); break;
                case "inventario": form = new InventarioForm(); break;
                case "reservas": form = new ReservasForm(); break;
                case "delivery": form = new DeliveryForm(); break;
                case "reportes": form = new ReportesForm(); break;
                case "configuracion":
                    var config = new SettingsForm();
                    config.RestaurantSaved += Config_RestaurantSaved;
                    form = config;
                    break;
                case "menu": form = new Form1 { Role = _role }; break;
                default:
                    route = "modulos";
                    if (_views.TryGetValue(route, out existing)) return existing;
                    form = new ModulesForm();
                    break;
            }
            var view = HostSectionForm(form);
            _views[route] = view;
            return view;
        }

        private void OnViewShown(string route, Control view)
        {
            if (view is PosForm pos) pos.ReloadTax();

            if (view is MesasForm mesas) mesas.RefreshView();

            if (view is ModulesForm modules) modules.LoadState();

            if (view is SettingsForm config) config.LoadData();
        }

        private void Config_RestaurantSaved(object sender, EventArgs e)
        {
            sidebar.SetBranch(LocalSettings.LoadRestaurantName(), LocalSettings.LoadAddress());
        }

        private void ShowPosForTable(string mesa)
        {
            var pos = (PosForm)GetOrCreateView("pos");
            pos.SetMesa(mesa);
            Navigate("pos");
        }

        private void ModuleStore_ModuleStateChanged(string module, bool enabled)
        {
            sidebar.SetModuleEnabled(module, enabled);
            if (enabled) return;
            string route = module == "salon" ? "mesas" : module;
            if (_currentRoute == route) Navigate("modulos");
        }

        /// <summary>
        /// Convierte el Form de una sección en contenido de la ventana principal:
        /// le quita el borde, lo acopla a <c>contentHost</c> y elimina su sidebar y su barra superior
        /// (esas copias solo están para que el diseñador muestre la app completa).
        /// </summary>
        private static Form HostSectionForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.MinimumSize = System.Drawing.Size.Empty;

            var chrome = new List<Control>();
            foreach (Control c in form.Controls)
                if (c is ShellSidebar || c is ShellTopBar) chrome.Add(c);
            foreach (var c in chrome)
            {
                form.Controls.Remove(c);
                c.Dispose();
            }

            form.Show();
            return form;
        }
    }
}
