using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class PosView : UserControl
    {
        private readonly ObservableCollection<Product> _products = new ObservableCollection<Product>();
        private readonly ObservableCollection<OrderLine> _ticket = new ObservableCollection<OrderLine>();
        private string _table = "Mesa no seleccionada";

        public PosView()
        {
            InitializeComponent();
            LoadProducts();
            CategoryBox.Items.Add("Todos");
            CategoryBox.Items.Add("Pizzas y pastas");
            CategoryBox.Items.Add("Carnes y parrilla");
            CategoryBox.Items.Add("Hamburguesas");
            CategoryBox.Items.Add("Bebidas");
            CategoryBox.Items.Add("Postres y café");
            CategoryBox.SelectedIndex = 0;
            RefreshTicket();
        }

        public void SetMesa(string table)
        {
            _table = string.IsNullOrWhiteSpace(table) ? "Mesa no seleccionada" : table;
            MesaLabel.Text = _table;
        }

        private void LoadProducts()
        {
            _products.Add(new Product("Pizza Napolitana Familiar", "Pizzas y pastas", 14500));
            _products.Add(new Product("Bife de Chorizo 400g", "Carnes y parrilla", 22000));
            _products.Add(new Product("Hamburguesa Doble Queso", "Hamburguesas", 12000));
            _products.Add(new Product("Cerveza Tirada IPA", "Bebidas", 5000));
            _products.Add(new Product("Limonada Menta y Jengibre", "Bebidas", 4500));
            _products.Add(new Product("Ensalada César con Pollo", "Carnes y parrilla", 9500));
            _products.Add(new Product("Tiramisú Casero", "Postres y café", 6000));
            _products.Add(new Product("Ravioles 4 Quesos", "Pizzas y pastas", 13500));
        }

        private void ApplyFilter()
        {
            if (ProductList == null) return;
            string text = (SearchBox?.Text ?? string.Empty).Trim();
            string category = CategoryBox?.SelectedItem?.ToString() ?? "Todos";
            ProductList.ItemsSource = _products.Where(p =>
                (category == "Todos" || p.Category == category) &&
                (text.Length == 0 || p.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0));
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e) => ApplyFilter();
        private void CategoryBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => ApplyFilter();

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            var product = (sender as Button)?.Tag as Product;
            if (product == null) return;
            var line = _ticket.FirstOrDefault(x => x.Product.Name == product.Name);
            if (line == null) _ticket.Add(new OrderLine(product));
            else line.Quantity++;
            RefreshTicket();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            var line = (sender as Button)?.Tag as OrderLine;
            if (line == null) return;
            line.Quantity++;
            RefreshTicket();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            var line = (sender as Button)?.Tag as OrderLine;
            if (line == null) return;
            line.Quantity--;
            if (line.Quantity <= 0) _ticket.Remove(line);
            RefreshTicket();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var line = (sender as Button)?.Tag as OrderLine;
            if (line == null) return;
            _ticket.Remove(line);
            RefreshTicket();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _ticket.Clear();
            RefreshTicket();
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            if (_ticket.Count == 0)
            {
                MessageBox.Show("Agregue productos al ticket antes de cobrar.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            decimal total = _ticket.Sum(x => x.LineTotal) * 1.08m;
            var checkout = new CheckoutWindow(total, _table) { Owner = Window.GetWindow(this) };
            if (checkout.ShowDialog() == true && checkout.PaymentConfirmed)
            {
                var receipt = new StringBuilder();
                receipt.AppendLine("RESTOOS");
                receipt.AppendLine("Recibo de demostración");
                receipt.AppendLine("----------------------------");
                foreach (OrderLine line in _ticket) receipt.AppendLine(line.Name + "  " + line.TotalText);
                receipt.AppendLine("----------------------------");
                receipt.AppendLine("Total: " + total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Pago: " + checkout.PaymentMethod);
                receipt.AppendLine("Recibido: " + checkout.PaidAmount.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Vuelto: " + checkout.ChangeAmount.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                new ReceiptWindow(receipt.ToString()) { Owner = Window.GetWindow(this) }.ShowDialog();
                _ticket.Clear();
                RefreshTicket();
            }
        }

        private void RefreshTicket()
        {
            if (TicketList == null) return;
            foreach (OrderLine line in _ticket) line.RaiseChanged();
            TicketList.ItemsSource = null;
            TicketList.ItemsSource = _ticket;
            decimal subtotal = _ticket.Sum(x => x.LineTotal);
            decimal tax = subtotal * 0.08m;
            SubtotalText.Text = subtotal.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            TaxText.Text = tax.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            TotalText.Text = (subtotal + tax).ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            ApplyFilter();
        }

        public class Product
        {
            public string Name { get; private set; }
            public string Category { get; private set; }
            public decimal Price { get; private set; }
            public string PriceText => Price.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public Product(string name, string category, decimal price) { Name = name; Category = category; Price = price; }
        }

        public class OrderLine : INotifyPropertyChanged
        {
            public Product Product { get; private set; }
            private int _quantity = 1;
            public int Quantity { get => _quantity; set { _quantity = value; RaiseChanged(); } }
            public string Name => Product.Name + (Quantity > 1 ? "  x" + Quantity : string.Empty);
            public string Detail => Product.PriceText + " c/u";
            public decimal LineTotal => Product.Price * Quantity;
            public string TotalText => LineTotal.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public OrderLine(Product product) { Product = product; }
            public event PropertyChangedEventHandler PropertyChanged;
            public void RaiseChanged() { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty)); }
        }
    }
}
