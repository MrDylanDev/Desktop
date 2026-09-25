using System;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class ModulesView : UserControl
    {
        private bool _initializing = true;
        public bool SalonEnabled { get; private set; } = true;
        public bool MenuEnabled { get; private set; } = true;
        public event Action<string, bool> ModuleStateChanged;

        public ModulesView()
        {
            InitializeComponent();
            _initializing = true;
            SalonToggle.IsChecked = true;
            MenuToggle.IsChecked = true;
            _initializing = false;
        }

        private void ModuleToggle_Changed(object sender, RoutedEventArgs e)
        {
            if (_initializing) return;
            if (ReferenceEquals(sender, SalonToggle))
            {
                SalonEnabled = SalonToggle.IsChecked == true;
                SalonStatus.Text = SalonToggle.IsChecked == true ? "Módulo activo" : "Módulo desactivado";
                SalonStatus.Foreground = SalonToggle.IsChecked == true
                    ? (System.Windows.Media.Brush)FindResource("Tertiary")
                    : (System.Windows.Media.Brush)FindResource("OnSurfaceVariant");
                ModuleStateChanged?.Invoke("salon", SalonToggle.IsChecked == true);
            }
            else if (ReferenceEquals(sender, MenuToggle))
            {
                MenuEnabled = MenuToggle.IsChecked == true;
                MenuStatus.Text = MenuToggle.IsChecked == true ? "Módulo activo" : "Módulo desactivado";
                MenuStatus.Foreground = MenuToggle.IsChecked == true
                    ? (System.Windows.Media.Brush)FindResource("Tertiary")
                    : (System.Windows.Media.Brush)FindResource("OnSurfaceVariant");
                ModuleStateChanged?.Invoke("menu", MenuToggle.IsChecked == true);
            }
        }
    }
}
