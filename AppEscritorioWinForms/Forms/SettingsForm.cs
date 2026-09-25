using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    public class SettingsForm : Form
    {
        private readonly string filePath;
        private readonly TextBox nameInput;
        private readonly TextBox addressInput;
        private readonly TextBox phoneInput;
        private readonly TextBox currencyInput;
        private readonly TextBox logoInput;

        public SettingsForm(string settingsFile)
        {
            filePath = settingsFile;
            Text = "Configuración del restaurante";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(520, 390);
            BackColor = Theme.BackgroundMedium;
            ForeColor = Theme.TextPrimary;
            ShowInTaskbar = false;
            var settings = SettingsStore.Load(filePath);
            nameInput = CreateInput(settings.RestaurantName, 30, 100);
            addressInput = CreateInput(settings.Address, 30, 145);
            phoneInput = CreateInput(settings.Phone, 30, 190);
            currencyInput = CreateInput(settings.CurrencySymbol, 30, 235);
            logoInput = CreateInput(settings.LogoPath, 30, 280);
            var save = new Button { Text = "Guardar configuración", Left = 330, Top = 325, Width = 165, Height = 38, BackColor = Theme.AccentSecondary, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = Theme.FontSmall };
            save.FlatAppearance.BorderSize = 0;
            save.Click += (s, e) => { SettingsStore.Save(filePath, new RestaurantSettings { RestaurantName = nameInput.Text.Trim(), Address = addressInput.Text.Trim(), Phone = phoneInput.Text.Trim(), CurrencySymbol = currencyInput.Text.Trim(), LogoPath = logoInput.Text.Trim() }); DialogResult = DialogResult.OK; Close(); };
            var browse = new Button { Text = "Elegir logo", Left = 330, Top = 278, Width = 120, Height = 30, BackColor = Theme.BackgroundLight, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            browse.Click += (s, e) => { using (var dialog = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp" }) if (dialog.ShowDialog(this) == DialogResult.OK) logoInput.Text = dialog.FileName; };
            Controls.Add(new Label { Text = "Nombre del restaurante", Left = 25, Top = 78, ForeColor = Theme.TextSecondary }); nameInput.Location = new Point(25, 100); Controls.Add(nameInput);
            Controls.Add(new Label { Text = "Dirección", Left = 25, Top = 123, ForeColor = Theme.TextSecondary }); addressInput.Location = new Point(25, 145); Controls.Add(addressInput);
            Controls.Add(new Label { Text = "Teléfono", Left = 25, Top = 168, ForeColor = Theme.TextSecondary }); phoneInput.Location = new Point(25, 190); Controls.Add(phoneInput);
            Controls.Add(new Label { Text = "Símbolo de moneda", Left = 25, Top = 213, ForeColor = Theme.TextSecondary }); currencyInput.Location = new Point(25, 235); Controls.Add(currencyInput);
            Controls.Add(new Label { Text = "Ruta del logo", Left = 25, Top = 258, ForeColor = Theme.TextSecondary }); logoInput.Location = new Point(25, 280); Controls.Add(logoInput);
            Controls.Add(browse); Controls.Add(save);
        }

        private static TextBox CreateInput(string value, int width, int top)
        {
            return new TextBox { Text = value ?? "", Width = width, Height = 28, BackColor = Theme.BackgroundDark, ForeColor = Theme.TextPrimary, Font = Theme.FontSmall, Location = new Point(25, top) };
        }
    }
}
