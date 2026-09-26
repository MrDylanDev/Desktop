using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public static class NavigationManager
    {
        public static Forms.PosForm PosView;
        public static Forms.MesasForm MesasView;
        public static Forms.KdsForm KdsView;
        public static Forms.InventarioForm InventarioView;
        public static Forms.ReservasForm ReservasView;
        public static Forms.DeliveryForm DeliveryView;
        public static Forms.ReportesForm ReportesView;
        public static Forms.ModulesForm ModulesView;
        public static Forms.SettingsForm SettingsView;
        public static Form1 MenuView;

        public static Form CurrentForm;
        public static string CurrentRole;

        public static void Initialize(string role)
        {
            CurrentRole = role;
            PosView = new Forms.PosForm() { Role = role };
            MesasView = new Forms.MesasForm() { Role = role };
            KdsView = new Forms.KdsForm() { Role = role };
            InventarioView = new Forms.InventarioForm() { Role = role };
            ReservasView = new Forms.ReservasForm() { Role = role };
            DeliveryView = new Forms.DeliveryForm() { Role = role };
            ReportesView = new Forms.ReportesForm() { Role = role };
            ModulesView = new Forms.ModulesForm() { Role = role };
            SettingsView = new Forms.SettingsForm() { Role = role };
            MenuView = new Form1() { Role = role };

            MesasView.MesaParaPos += (tableName) =>
            {
                PosView.SetMesa(tableName);
                NavigateTo(PosView);
            };

            // Asegurar que si cierran cualquier pantalla, se cierre la app
            PosView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            MesasView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            KdsView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            InventarioView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            ReservasView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            DeliveryView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            ReportesView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            ModulesView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            SettingsView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
            MenuView.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0 || e.CloseReason == CloseReason.UserClosing) Application.Exit(); };
        }

        public static void NavigateTo(Form nextForm)
        {
            if (nextForm is Forms.ReportesForm && nextForm.GetType().GetProperty("Role")?.GetValue(nextForm)?.ToString() != "Admin")
            {
                MessageBox.Show("Solo el Administrador puede ver Reportes.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nextForm is Forms.SettingsForm && nextForm.GetType().GetProperty("Role")?.GetValue(nextForm)?.ToString() != "Admin")
            {
                MessageBox.Show("Solo el Administrador puede ver Configuración.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NavigateToCore(nextForm);
        }

        private static void NavigateToCore(Form nextForm)
        {
            if (nextForm == null) return;
            if (CurrentForm != null && CurrentForm != nextForm)
            {
                nextForm.StartPosition = FormStartPosition.Manual;
                nextForm.Location = CurrentForm.Location;
                nextForm.Size = CurrentForm.Size;
                nextForm.WindowState = CurrentForm.WindowState;
                CurrentForm.Hide();
            }
            CurrentForm = nextForm;
            nextForm.Show();
        }
    }
}


