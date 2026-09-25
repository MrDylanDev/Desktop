using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    /// <summary>
    /// Apartado Menú: hospeda el editor de carta de David (AppEscritorioWinForms.Form1)
    /// tal cual, sin reimplementar nada. Los datos viven en data\menu.xml junto al exe.
    /// </summary>
    public partial class MenuView : UserControl
    {
        private bool _hosted;
        private app_escritorio.Form1 _menuForm;

        public MenuView()
        {
            InitializeComponent();
            Loaded += MenuView_Loaded;
        }

        private void MenuView_Loaded(object sender, RoutedEventArgs e)
        {
            if (_hosted) return;
            _hosted = true;
            try
            {
                EnsureMenuData();
                _menuForm = new app_escritorio.Form1();
                _menuForm.TopLevel = false;
                _menuForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                _menuForm.Dock = System.Windows.Forms.DockStyle.Fill;
                MenuHost.Child = _menuForm;
                _menuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el menú de David: " + ex.Message, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Siembra inicial: copia la carta del repo a data\menu.xml junto al exe
        /// para que el editor arranque con los platos reales.
        /// </summary>
        private static void EnsureMenuData()
        {
            try
            {
                string targetDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
                string target = Path.Combine(targetDir, "menu.xml");
                if (File.Exists(target)) return;
                string dir = AppDomain.CurrentDomain.BaseDirectory;
                for (int i = 0; i < 8 && !string.IsNullOrEmpty(dir); i++)
                {
                    string seed = Path.Combine(dir, "AppEscritorioWinForms", "Data", "menu.xml");
                    if (File.Exists(seed))
                    {
                        Directory.CreateDirectory(targetDir);
                        File.Copy(seed, target);
                        return;
                    }
                    dir = Path.GetDirectoryName(dir);
                }
            }
            catch { }
        }
    }
}
