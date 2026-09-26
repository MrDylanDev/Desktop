using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>Interruptor on/off (reemplaza al CheckBox claro). Verde Tertiary cuando está activo.</summary>
    [ToolboxItem(true)]
    [DefaultEvent("CheckedChanged")]
    [DefaultProperty("Checked")]
    [Description("Interruptor temático RestoOS.")]
    public class RSwitch : Control
    {
        private bool _checked;

        public event EventHandler CheckedChanged;

        public RSwitch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable, true);
            base.BackColor = Color.Transparent;
            base.Font = Theme.GetFont(9.75F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            Size = new Size(200, 28);
        }

        [Category("RestoOS"), DefaultValue(false)]
        public bool Checked
        {
            get => _checked;
            set
            {
                if (_checked == value) return;
                _checked = value;
                Invalidate();
                CheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => base.Text; set { base.Text = value; Invalidate(); } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        protected override void OnClick(EventArgs e)
        {
            if (Enabled) Checked = !Checked;
            base.OnClick(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) Checked = !Checked;
            base.OnKeyUp(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));

        protected override void OnPaint(PaintEventArgs e)
        {
            var bg = UiHelpers.EffectiveBackColor(this);
            int h = Math.Min(Height - 4, 22), w = h * 2 - 4, y = (Height - h) / 2;
            var track = new Rectangle(0, y, w, h);
            Color trackColor = _checked ? Theme.Tertiary : Theme.SurfaceHighest;
            if (!Enabled) trackColor = Theme.Blend(trackColor, bg, 0.45);
            UiHelpers.FillRounded(e.Graphics, trackColor, track, h / 2);

            int k = h - 6, kx = _checked ? w - k - 3 : 3;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(_checked ? Theme.OnTertiary : Theme.OnSurfaceVariant))
                e.Graphics.FillEllipse(b, kx, y + 3, k, k);

            var fg = _checked ? Theme.Tertiary : Theme.OnSurfaceVariant;
            if (!Enabled) fg = Theme.Blend(fg, bg, 0.45);
            var rect = new Rectangle(w + 10, 0, Width - w - 10, Height);
            TextRenderer.DrawText(e.Graphics, Text, Font, rect, fg, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);
        }
    }
}
