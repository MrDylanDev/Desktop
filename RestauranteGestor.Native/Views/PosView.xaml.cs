using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class PosView : UserControl
    {
        private readonly ObservableCollection<Product> _products = new ObservableCollection<Product>();
        private static readonly System.Collections.Generic.Dictionary<string, ObservableCollection<OrderLine>> _allTickets = new System.Collections.Generic.Dictionary<string, ObservableCollection<OrderLine>>();
        public static ObservableCollection<OrderLine> GetTicketFor(string mesa)
        {
            string key = string.IsNullOrWhiteSpace(mesa) || mesa == "Mesa no seleccionada" ? "__GENERAL__" : mesa;
            if (!_allTickets.TryGetValue(key, out var col)) { col = new ObservableCollection<OrderLine>(); _allTickets[key] = col; }
            return col;
        }
        public static decimal GetTotalFor(string mesa) => GetTicketFor(mesa).Sum(l => l.LineTotal);
        public static string GetDetalleFor(string mesa)
        {
            var t = GetTicketFor(mesa);
            if (t.Count == 0) return string.Empty;
            return string.Join(", ", t.Select(l => l.Name));
        }
        private ObservableCollection<OrderLine> _ticket;
        private string _table = "Mesa no seleccionada";
        private decimal _taxRate = 0.08m;

        public PosView()
        {
            InitializeComponent();
            _ticket = GetTicketFor(_table);
            LoadProducts();
            CategoryBox.Items.Add("Todos");
            CategoryBox.Items.Add("Pizzas y pastas");
            CategoryBox.Items.Add("Carnes y parrilla");
            CategoryBox.Items.Add("Hamburguesas");
            CategoryBox.Items.Add("Bebidas");
            CategoryBox.Items.Add("Postres y café");
            CategoryBox.SelectedIndex = 0;
            TaxSelector.Items.Add("Exento — 0%");
            TaxSelector.Items.Add("INC — 8%");
            TaxSelector.Items.Add("IVA — 19%");
            TaxSelector.SelectedIndex = 1;
            ApplySavedTax();
            Loaded += PosView_Loaded;
            RefreshTicket();
        }

        private void PosView_Loaded(object sender, RoutedEventArgs e)
        {
            TipoPedidoBox.Items.Clear();
            TipoPedidoBox.Items.Add("Salón (mesa)");
            TipoPedidoBox.Items.Add("Para llevar");
            // Solo muestra Domicilio si Delivery está activo
            bool deliveryOn = false;
            try { deliveryOn = File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat")) ? File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat")).Contains("delivery=1") : false; } catch { }
            if (deliveryOn) TipoPedidoBox.Items.Add("Domicilio propio");
            TipoPedidoBox.SelectedIndex = 0;
            UpdateDomicilioVisibility();
        }

        private void TipoPedido_Changed(object sender, SelectionChangedEventArgs e) => UpdateDomicilioVisibility();

        private void UpdateDomicilioVisibility()
        {
            if (DomicilioPanel == null) return;
            bool deliveryOn = false;
            try { deliveryOn = File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat")) ? File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat")).Contains("delivery=1") : false; } catch { }
            DomicilioPanel.Visibility = deliveryOn ? Visibility.Visible : Visibility.Collapsed;
            if (DeliveryBadge != null) DeliveryBadge.Visibility = deliveryOn ? Visibility.Visible : Visibility.Collapsed;
            string tipo = TipoPedidoBox?.SelectedItem?.ToString() ?? "Salón (mesa)";
            bool isDom = tipo.Contains("Domicilio");
            if (DomicilioFields != null) DomicilioFields.Visibility = isDom ? Visibility.Visible : Visibility.Collapsed;
            if (DestinoLabel != null)
            {
                if (isDom)
                {
                    string cliente = (ClienteDomBox?.Text ?? "").Trim();
                    string dir = (DirDomBox?.Text ?? "").Trim();
                    DestinoLabel.Text = (cliente.Length > 0 ? cliente : "Cliente") + (dir.Length > 0 ? " · " + dir : "");
                }
                else if (tipo.Contains("Para llevar")) DestinoLabel.Text = "Para llevar";
                else DestinoLabel.Text = _table;
            }
        }

        public void SetMesa(string table)
        {
            _table = string.IsNullOrWhiteSpace(table) ? "Mesa no seleccionada" : table;
            MesaLabel.Text = _table;
            _ticket = GetTicketFor(_table);
            RefreshTicket();
            UpdateDomicilioVisibility();
        }

        /// <summary>
        /// Aplica el impuesto por defecto guardado en Configuración.
        /// </summary>
        public void ReloadTax()
        {
            ApplySavedTax();
            RefreshTicket();
        }

        private void ApplySavedTax()
        {
            int p = ConfiguracionView.LoadTaxPercent();
            if (TaxSelector == null) { _taxRate = p == 0 ? 0m : (p == 19 ? 0.19m : 0.08m); return; }
            TaxSelector.SelectionChanged -= TaxSelector_SelectionChanged;
            if (p == 0) { _taxRate = 0m; TaxSelector.SelectedIndex = 0; }
            else if (p == 19) { _taxRate = 0.19m; TaxSelector.SelectedIndex = 2; }
            else { _taxRate = 0.08m; TaxSelector.SelectedIndex = 1; }
            TaxSelector.SelectionChanged += TaxSelector_SelectionChanged;
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

        private void TaxSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TaxSelector == null || TaxSelector.SelectedIndex < 0) return;
            if (!IsLoaded) return;
            if (TaxSelector.SelectedIndex == 0) _taxRate = 0m;
            else if (TaxSelector.SelectedIndex == 2) _taxRate = 0.19m;
            else _taxRate = 0.08m;
            RefreshTicket();
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            var product = (sender as Button)?.Tag as Product;
            if (product == null) return;
            var line = _ticket.FirstOrDefault(x => x.Product.Name == product.Name && string.IsNullOrEmpty(x.Notes));
            if (line == null) _ticket.Add(new OrderLine(product));
            else line.Quantity++;
            RefreshTicket();
        }

        private void Note_Click(object sender, RoutedEventArgs e)
        {
            var line = (sender as Button)?.Tag as OrderLine;
            if (line == null) return;
            var dialog = new NoteWindow(line.Product.Name, line.Notes) { Owner = Window.GetWindow(this) };
            if (dialog.ShowDialog() == true)
            {
                line.Notes = dialog.NoteResult;
                RefreshTicket();
            }
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
            string tipo = TipoPedidoBox?.SelectedItem?.ToString() ?? "Salón (mesa)";
            bool isDom = tipo.Contains("Domicilio");
            if (isDom)
            {
                if (string.IsNullOrWhiteSpace(ClienteDomBox?.Text) || string.IsNullOrWhiteSpace(DirDomBox?.Text))
                {
                    MessageBox.Show("Para domicilio completa cliente y dirección.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            decimal total = _ticket.Sum(x => x.LineTotal) * (1 + _taxRate);
            string mesaParaCobro = isDom ? "Domicilio: " + ClienteDomBox.Text.Trim() + " · " + DirDomBox.Text.Trim() : (tipo.Contains("Para llevar") ? "Para llevar" : _table);
            var checkout = new CheckoutWindow(total, mesaParaCobro) { Owner = Window.GetWindow(this) };
            if (checkout.ShowDialog() == true && checkout.PaymentConfirmed)
            {
                var receipt = new StringBuilder();
                receipt.AppendLine("RESTOOS");
                receipt.AppendLine("Recibo de demostración");
                receipt.AppendLine("Tipo: " + tipo);
                if (!string.IsNullOrWhiteSpace(mesaParaCobro) && mesaParaCobro != "Mesa no seleccionada") receipt.AppendLine(mesaParaCobro);
                if (isDom) { receipt.AppendLine("Tel: " + TelDomBox.Text.Trim()); receipt.AppendLine("Dir: " + DirDomBox.Text.Trim()); }
                receipt.AppendLine("----------------------------");
                foreach (OrderLine line in _ticket)
                {
                    receipt.AppendLine(line.Name + "  " + line.TotalText);
                    if (!string.IsNullOrEmpty(line.Notes)) receipt.AppendLine("  > " + line.Notes);
                }
                receipt.AppendLine("----------------------------");
                decimal subtotal = _ticket.Sum(x => x.LineTotal);
                receipt.AppendLine("Subtotal: " + subtotal.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Impuesto (" + (_taxRate * 100).ToString("0") + "%): " + (subtotal * _taxRate).ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Total: " + total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Pago: " + checkout.PaymentMethod);
                receipt.AppendLine("Recibido: " + checkout.PaidAmount.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                receipt.AppendLine("Vuelto: " + checkout.ChangeAmount.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));
                new ReceiptWindow(receipt.ToString()) { Owner = Window.GetWindow(this) }.ShowDialog();
                _ticket.Clear();
                if (isDom) { ClienteDomBox.Text = ""; TelDomBox.Text = ""; DirDomBox.Text = ""; TipoPedidoBox.SelectedIndex = 0; }
                RefreshTicket();
                UpdateDomicilioVisibility();
            }
        }

        public static event Action TicketChanged;

        private void RefreshTicket()
        {
            if (TicketList == null || SubtotalText == null || TaxText == null || TotalText == null) return;
            if (_ticket == null) _ticket = GetTicketFor(_table);
            foreach (OrderLine line in _ticket) line.RaiseChanged();
            TicketList.ItemsSource = null;
            TicketList.ItemsSource = _ticket;
            decimal subtotal = _ticket.Sum(x => x.LineTotal);
            decimal tax = subtotal * _taxRate;
            SubtotalText.Text = subtotal.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            if (TaxLabel != null) TaxLabel.Text = "Impuesto (" + (_taxRate * 100).ToString("0") + "%)";
            TaxText.Text = tax.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            TotalText.Text = (subtotal + tax).ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            ApplyFilter();
            TicketChanged?.Invoke();
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
            private string _notes = string.Empty;
            public int Quantity { get => _quantity; set { _quantity = value; RaiseChanged(); } }
            public string Notes { get => _notes; set { _notes = value ?? string.Empty; RaiseChanged(); } }
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
