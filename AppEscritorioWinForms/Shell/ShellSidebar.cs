using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using app_escritorio.UI;

namespace app_escritorio.Shell
{
    public class NavigateEventArgs : EventArgs
    {
        public NavigateEventArgs(string route) { Route = route; }
        public string Route { get; }
    }

    public delegate void NavigateEventHandler(object sender, NavigateEventArgs e);

    /// <summary>
    /// Barra lateral de la ventana principal (copia del sidebar de MainWindow.xaml de WPF).
    /// Se edita en el diseñador: cada botón tiene en <c>Tag</c> la ruta a la que navega.
    /// </summary>
    public partial class ShellSidebar : UserControl
    {
        /// <summary>Se dispara al pulsar un botón de navegación; e.Route es el Tag del botón.</summary>
        [Category("RestoOS")]
        public event NavigateEventHandler NavigateRequested;

        private string _activeRoute = "";

        public ShellSidebar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ruta resaltada (pos, mesas, kds, inventario, reservas, delivery, menu, modulos, reportes, configuracion).
        /// Cada Form de sección la pone en el diseñador para verse igual que en la app.
        /// </summary>
        [Category("RestoOS"), DefaultValue(""), Description("Ruta del botón resaltado.")]
        public string ActiveRoute
        {
            get => _activeRoute;
            set { _activeRoute = value ?? ""; SetActive(_activeRoute); }
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            if (sender is Control c && c.Tag is string route && !string.IsNullOrEmpty(route))
                NavigateRequested?.Invoke(this, new NavigateEventArgs(route));
        }

        /// <summary>
        /// Operación la ven todos; Administración (Módulos, Reportes, Configuración) solo el Admin.
        /// El Admin tiene acceso completo: POS, Mesas, KDS, Inventario, Reservas, Delivery y Menú.
        /// </summary>
        public void SetRole(bool isAdmin)
        {
            flowOperacion.Visible = true;
            flowAdmin.Visible = isAdmin;
            btnConfigModulos.Visible = false; // duplicaba "Selector de Módulos"
            FitContent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            FitContent();
        }

        /// <summary>
        /// Evita la barra de desplazamiento: si el menú no cabe (pantallas bajas o Admin con las dos secciones),
        /// oculta primero la tarjeta de sucursal y luego el chip "Operando local".
        /// </summary>
        private void FitContent()
        {
            if (flowMain == null || UiHelpers.IsDesignTime) return;
            cardSucursal.Visible = true;
            badgeLocal.Visible = true;
            if (NeededHeight() > flowMain.ClientSize.Height) cardSucursal.Visible = false;
            if (NeededHeight() > flowMain.ClientSize.Height) badgeLocal.Visible = false;
        }

        private int NeededHeight()
        {
            int h = flowMain.Padding.Vertical;
            foreach (Control c in flowMain.Controls)
                if (c.Visible) h += (c.AutoSize ? c.GetPreferredSize(new System.Drawing.Size(flowMain.Width, 0)).Height : c.Height) + c.Margin.Vertical;
            return h;
        }

        /// <summary>Resalta el botón de la ruta activa.</summary>
        public void SetActive(string route)
        {
            _activeRoute = route ?? "";
            foreach (var b in NavButtons())
                b.Selected = b != btnConfigModulos && string.Equals(b.Tag as string, route, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Habilita o deshabilita la entrada de un módulo (clave de modules.dat).</summary>
        public void SetModuleEnabled(string module, bool enabled)
        {
            var b = ButtonForModule(module);
            if (b != null) b.Enabled = enabled;
        }

        public bool IsRouteAvailable(string route)
        {
            foreach (var b in NavButtons())
                if (string.Equals(b.Tag as string, route, StringComparison.OrdinalIgnoreCase) && b != btnConfigModulos)
                    return b.Enabled && b.Parent != null && b.Parent.Visible;
            return false;
        }

        /// <summary>Nombre y detalle de la sucursal (Configuración del restaurante).</summary>
        public void SetBranch(string name, string detail)
        {
            if (!string.IsNullOrWhiteSpace(name)) lblSucName.Text = name;
            if (detail != null) lblSucSub.Text = detail;
        }

        private RButton ButtonForModule(string module)
        {
            switch (module)
            {
                case "salon": return btnMesas;
                case "menu": return btnMenu;
                case "kds": return btnKds;
                case "inventario": return btnInventario;
                case "reservas": return btnReservas;
                case "delivery": return btnDelivery;
                case "reportes": return btnReportes;
                default: return null;
            }
        }

        private IEnumerable<RButton> NavButtons()
        {
            return new[] { btnPos, btnMesas, btnKds, btnInventario, btnReservas, btnDelivery, btnMenu,
                           btnModulos, btnReportes, btnConfiguracion, btnConfigModulos };
        }
    }
}
