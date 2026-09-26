using System;
using System.Windows.Forms;

namespace app_escritorio.Shell
{
    /// <summary>
    /// Barra superior (reloj, ruta, rol, "Cambiar perfil"), igual a la de MainWindow.xaml de WPF.
    /// </summary>
    public partial class ShellTopBar : UserControl
    {
        public event EventHandler CambiarPerfilClicked;

        public ShellTopBar()
        {
            InitializeComponent();
        }

        /// <summary>Texto de la ruta actual ("POS", "Mesas y Salón"...).</summary>
        public string RouteText
        {
            get => lblRoute.Text;
            set => lblRoute.Text = value;
        }

        /// <summary>Texto del chip de rol ("Administrador" / "Empleados").</summary>
        public string RoleText
        {
            get => badgeRole.Text;
            set => badgeRole.Text = value;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            UpdateClock();
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e) => UpdateClock();

        private void UpdateClock() => badgeClock.Text = DateTime.Now.ToString("HH:mm:ss");

        private void BtnCambiarPerfil_Click(object sender, EventArgs e) => CambiarPerfilClicked?.Invoke(this, EventArgs.Empty);
    }
}
