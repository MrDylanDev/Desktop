using System;
using System.Windows.Forms;

namespace app_escritorio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Login → ventana principal (ShellForm). "Cambiar perfil" vuelve al login.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                string role;
                using (var loginForm = new Forms.LoginForm())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK) return;
                    role = loginForm.Role;
                }

                // Los formularios viejos (Mesas, KDS, Menú...) todavía leen el rol desde aquí.
                Forms.NavigationManager.CurrentRole = role;

                using (var shell = new Shell.ShellForm(role))
                {
                    Application.Run(shell);
                    if (!shell.ChangeProfileRequested) return;
                }
            }
        }
    }
}
