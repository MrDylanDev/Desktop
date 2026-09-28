using System;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>Agregar, ordenar y eliminar categorías de la carta (los cambios se aplican sobre la carta abierta).</summary>
    public partial class CategoriasDialogForm : RDialogForm
    {
        private readonly MenuData _data;

        public CategoriasDialogForm() : this(new MenuData()) { }

        public CategoriasDialogForm(MenuData data)
        {
            InitializeComponent();
            _data = data;
            if (!UiHelpers.IsDesignTime) Render(0);
        }

        private void Render(int select)
        {
            grid.Rows.Clear();
            foreach (var c in _data.Categories)
            {
                int i = grid.Rows.Add(c.Name, _data.Items.Count(x => x.CategoryId == c.Id));
                grid.Rows[i].Tag = c;
            }
            if (grid.Rows.Count > 0)
            {
                select = Math.Max(0, Math.Min(select, grid.Rows.Count - 1));
                grid.ClearSelection();
                grid.Rows[select].Selected = true;
                grid.CurrentCell = grid.Rows[select].Cells[0];
            }
        }

        private int SelectedIndex => grid.CurrentRow?.Index ?? -1;

        private void Renumber()
        {
            for (int i = 0; i < _data.Categories.Count; i++) _data.Categories[i].Position = i;
        }

        private void Move(int delta)
        {
            int i = SelectedIndex, j = i + delta;
            if (i < 0 || j < 0 || j >= _data.Categories.Count) return;
            var c = _data.Categories[i];
            _data.Categories.RemoveAt(i);
            _data.Categories.Insert(j, c);
            Renumber();
            Render(j);
        }

        private void BtnSubir_Click(object sender, EventArgs e) => Move(-1);
        private void BtnBajar_Click(object sender, EventArgs e) => Move(1);

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            int i = SelectedIndex;
            if (i < 0) return;
            var c = _data.Categories[i];
            int platos = _data.Items.Count(x => x.CategoryId == c.Id);
            if (platos > 0)
            {
                MessageBox.Show("\"" + c.Name + "\" tiene " + platos + " plato(s). Muévelos a otra categoría o elimínalos primero.",
                    "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_data.Categories.Count == 1) return;
            _data.Categories.RemoveAt(i);
            Renumber();
            Render(i);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string name = txtNueva.Text.Trim();
            if (name.Length == 0) { txtNueva.Focus(); return; }
            if (_data.Categories.Any(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe esa categoría.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _data.Categories.Add(new Category { Name = name, Position = _data.Categories.Count });
            txtNueva.Clear();
            Render(_data.Categories.Count - 1);
            txtNueva.Focus();
        }
    }
}
