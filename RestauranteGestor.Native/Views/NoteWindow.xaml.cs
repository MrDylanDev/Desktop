using System.Windows;

namespace RestauranteGestor.Native.Views
{
    public partial class NoteWindow : Window
    {
        public string NoteResult { get; private set; }

        public NoteWindow(string productName, string currentNote)
        {
            InitializeComponent();
            TitleText.Text = productName;
            NoteBox.Text = currentNote ?? string.Empty;
            NoteBox.Focus();
            NoteBox.SelectAll();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) { DialogResult = false; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            NoteResult = (NoteBox.Text ?? string.Empty).Trim();
            DialogResult = true;
        }
    }
}
