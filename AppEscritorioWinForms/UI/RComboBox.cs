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

        // El estilo Flat de Windows dibuja un marco blanco y una flecha clara: se repintan con los colores del tema.
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_PAINT = 0x000F, WM_NCPAINT = 0x0085;
            if ((m.Msg != WM_PAINT && m.Msg != WM_NCPAINT) || !IsHandleCreated) return;
            using (var g = Graphics.FromHwnd(Handle))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var outer = new Rectangle(0, 0, Width - 1, Height - 1);
                var parentBg = UiHelpers.EffectiveBackColor(this);

                // Esquinas redondeadas: lo que queda fuera se pinta del color del fondo
                using (var path = UiHelpers.RoundedRect(outer, 8))
                using (var outside = new Region(new Rectangle(0, 0, Width, Height)))
                {
                    outside.Exclude(path);
                    using (var b = new SolidBrush(parentBg)) g.FillRegion(b, outside);
                }

                // Zona de la flecha
                var arrow = new Rectangle(Width - 26, 2, 24, Height - 4);
                using (var b = new SolidBrush(Theme.SurfaceHigh)) g.FillRectangle(b, arrow);
                int cx = arrow.X + arrow.Width / 2, cy = Height / 2;
                using (var pen = new Pen(Enabled ? Theme.OnSurfaceVariant : Theme.Blend(Theme.OnSurfaceVariant, Theme.SurfaceHigh, 0.45), 1.6f))
                    g.DrawLines(pen, new[] { new Point(cx - 4, cy - 2), new Point(cx, cy + 2), new Point(cx + 4, cy - 2) });

                UiHelpers.DrawRounded(g, Focused || DroppedDown ? Theme.Primary : Theme.SurfaceHighest, outer, 8, 1f);
            }
        }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }

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
