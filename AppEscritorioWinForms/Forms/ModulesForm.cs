using System;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.UI;
using app_escritorio.Views.Modulos;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Módulos / Escalabilidad (migración de ModulesView.xaml de WPF).
    /// Las tarjetas son <see cref="ModuleCard"/> editables en el diseñador; aquí solo se lee y guarda el estado.
    /// </summary>
    public partial class ModulesForm : Form
    {
        private bool _loading;

        public ModulesForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;
            LoadState();
        }

        /// <summary>Marca cada interruptor según modules.dat.</summary>
        public void LoadState()
        {
            _loading = true;
            foreach (Control c in flowCards.Controls)
                if (c is ModuleCard card && !card.IsCore)
                    card.ModuleEnabled = ModuleStore.IsEnabled(card.ModuleKey);
            _loading = false;
        }

        private void Card_ModuleToggled(object sender, EventArgs e)
        {
            if (_loading || !(sender is ModuleCard card)) return;
            ModuleStore.SetEnabled(card.ModuleKey, card.ModuleEnabled);
        }
    }
}
