using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
            ProductsList.ItemsSource = new ObservableCollection<MenuProduct>
            {
                new MenuProduct("Pizza Napolitana Familiar", "Pizzas y pastas", 14500),
                new MenuProduct("Bife de Chorizo 400g", "Carnes y parrilla", 22000),
                new MenuProduct("Hamburguesa Doble Queso", "Hamburguesas", 12000),
                new MenuProduct("Cerveza Tirada IPA", "Bebidas", 5000),
                new MenuProduct("Tiramisú Casero", "Postres y café", 6000)
            };
        }

        public class MenuProduct : INotifyPropertyChanged
        {
            private bool _available = true;
            public string Name { get; private set; }
            public string Category { get; private set; }
            public decimal Price { get; private set; }
            public string PriceText { get { return Price.ToString("C0", CultureInfo.GetCultureInfo("es-CO")); } }
            public bool Available { get { return _available; } set { _available = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Available")); } }
            public MenuProduct(string name, string category, decimal price) { Name = name; Category = category; Price = price; }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
