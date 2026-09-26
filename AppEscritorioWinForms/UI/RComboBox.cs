using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>
    /// ComboBox oscuro (lista desplegable con fondo SurfaceHigh, ítem seleccionado en Primary), como el de WPF.
    /// Los ítems se editan en el diseñador con la propiedad Items.
    /// </summary>
    [ToolboxItem(true)]
    [Description("Lista desplegable temática RestoOS.")]
    public class RComboBox : ComboBox
    {
        public RComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            base.BackColor = Theme.SurfaceHigh;
            base.ForeColor = Theme.OnSurface;
            base.Font = Theme.GetFont(9.75F);
            ItemHeight = 26;
            Cursor = Cursors.Hand;
        }

        [DefaultValue(DrawMode.OwnerDrawFixed)]
        public new DrawMode DrawMode { get => base.DrawMode; set => base.DrawMode = value; }

        [DefaultValue(ComboBoxStyle.DropDownList)]
        public new ComboBoxStyle DropDownStyle { get => base.DropDownStyle; set => base.DropDownStyle = value; }

        [DefaultValue(FlatStyle.Flat)]
        public new FlatStyle FlatStyle { get => base.FlatStyle; set => base.FlatStyle = value; }

        [DefaultValue(26)]
        public new int ItemHeight { get => base.ItemHeight; set => base.ItemHeight = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get => base.Font; set { } }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UiHelpers.ApplyDarkScrollbars(this);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            bool isEdit = (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit;
            bool highlighted = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color bg = isEdit ? Theme.SurfaceHigh : (highlighted ? Theme.SurfaceHighest : Theme.SurfaceHigh);
            Color fg = Theme.OnSurface;
            if (!isEdit && e.Index >= 0 && e.Index == SelectedIndex) fg = Theme.Primary;
            if (!Enabled) fg = Theme.Blend(fg, bg, 0.45);

            using (var b = new SolidBrush(bg)) e.Graphics.FillRectangle(b, e.Bounds);
            if (e.Index >= 0)
            {
                var font = (!isEdit && e.Index == SelectedIndex) ? Theme.GetFont(Font.Size, FontStyle.Bold) : Font;
                var rect = new Rectangle(e.Bounds.X + 8, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), font, rect, fg,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            }
        }
    }
}
