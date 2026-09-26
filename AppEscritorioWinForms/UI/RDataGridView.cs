using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>
    /// Tabla oscura (equivale a ListView/GridView con los headers del tema WPF).
    /// Extras sin código: en una columna pon <c>Tag = "chip"</c> para pintar el texto como insignia
    /// del color de la celda (Estado, Plataforma...). Las columnas de botón se pintan como RButton:
    /// <c>Tag = "danger"</c> (rojo), <c>"primary"</c> (melocotón) o vacío (gris).
    /// </summary>
    [ToolboxItem(true)]
    [Description("Tabla temática RestoOS.")]
    public class RDataGridView : DataGridView
    {
        public RDataGridView()
        {
            DoubleBuffered = true;
            AutoGenerateColumns = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            ReadOnly = true;
            MultiSelect = false;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 36;
            EnableHeadersVisualStyles = false;
            RowTemplate.Height = 40;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackgroundColor = Theme.SurfaceLowest;
            GridColor = Theme.SurfaceHigh;
            ColumnHeadersDefaultCellStyle.BackColor = Theme.SurfaceLowest;
            ColumnHeadersDefaultCellStyle.ForeColor = Theme.OnSurfaceVariant;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.SurfaceLowest;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Theme.OnSurfaceVariant;
            ColumnHeadersDefaultCellStyle.Font = Theme.GetFont(8.25F, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            DefaultCellStyle.BackColor = Theme.SurfaceLowest;
            DefaultCellStyle.ForeColor = Theme.OnSurface;
            DefaultCellStyle.SelectionBackColor = Theme.SurfaceHigh;
            DefaultCellStyle.SelectionForeColor = Theme.OnSurface;
            DefaultCellStyle.Font = Theme.GetFont(9.75F);
            DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UiHelpers.ApplyDarkScrollbars(this);
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);
            if (e.Handled || e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var col = Columns[e.ColumnIndex];
            string tag = col.Tag as string ?? string.Empty;
            bool isButton = col is DataGridViewButtonColumn;
            if (!isButton && tag != "chip") return;

            bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
            var bg = selected ? e.CellStyle.SelectionBackColor : e.CellStyle.BackColor;
            e.PaintBackground(e.CellBounds, selected);
            string text = Convert.ToString(e.FormattedValue);
            if (string.IsNullOrEmpty(text)) { e.Handled = true; return; }

            var font = Theme.GetFont(8.25F, FontStyle.Bold);
            var textSize = TextRenderer.MeasureText(text, font);
            if (isButton)
            {
                Color fill = tag == "danger" ? Theme.ErrorContainer : tag == "primary" ? Theme.Primary : Theme.SurfaceHigh;
                Color fg = tag == "danger" ? Theme.Error : tag == "primary" ? Theme.OnPrimary : Theme.OnSurface;
                int w = Math.Min(e.CellBounds.Width - 8, Math.Max(textSize.Width + 16, 28));
                var r = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + (e.CellBounds.Height - 26) / 2, w, 26);
                UiHelpers.FillRounded(e.Graphics, fill, r, 6);
                TextRenderer.DrawText(e.Graphics, text, font, r, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }
            else
            {
                var fg = e.CellStyle.ForeColor;
                int w = Math.Min(e.CellBounds.Width - 12, textSize.Width + 14);
                var r = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + (e.CellBounds.Height - 22) / 2, w, 22);
                UiHelpers.FillRounded(e.Graphics, Theme.Blend(fg, bg, 0.18), r, 6);
                TextRenderer.DrawText(e.Graphics, text, font, r, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }
            e.Handled = true;
        }
    }
}
