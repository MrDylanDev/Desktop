using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>
    /// Caja de texto temática (fondo SurfaceHigh, esquinas de 8px, borde Primary al enfocar), igual al TextBox de WPF.
    /// Tiene PlaceholderText, Multiline, MaxLength y ReadOnly como un TextBox normal.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("TextChanged")]
    [DefaultProperty("Text")]
    [Description("Caja de texto temática RestoOS.")]
    public class RTextBox : Control
    {
        private readonly TextBox _inner;
        private int _cornerRadius = 8;

        public RTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;

            _inner = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Theme.SurfaceHigh,
                ForeColor = Theme.OnSurface,
                Font = Theme.GetFont(9.75F)
            };
            _inner.TextChanged += (s, e) => OnTextChanged(e);
            _inner.GotFocus += (s, e) => Invalidate();
            _inner.LostFocus += (s, e) => Invalidate();
            _inner.KeyDown += (s, e) => OnKeyDown(e);
            _inner.KeyPress += (s, e) => OnKeyPress(e);
            _inner.KeyUp += (s, e) => OnKeyUp(e);
            Controls.Add(_inner);

            Padding = new Padding(10, 8, 10, 8);
            Size = new Size(220, 38);
            Cursor = Cursors.IBeam;
        }

        // ===================== Propiedades =====================

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public override string Text
        {
            get => _inner.Text;
            set { _inner.Text = value ?? string.Empty; }
        }

        [Category("RestoOS"), DefaultValue("")]
        [Description("Texto guía que se muestra cuando la caja está vacía.")]
        public string PlaceholderText
        {
            get => _inner.PlaceholderText;
            set => _inner.PlaceholderText = value ?? string.Empty;
        }

        [Category("Behavior"), DefaultValue(false)]
        public bool Multiline
        {
            get => _inner.Multiline;
            set { _inner.Multiline = value; _inner.ScrollBars = value ? ScrollBars.Vertical : ScrollBars.None; _inner.WordWrap = value; LayoutInner(); }
        }

        [Category("Behavior"), DefaultValue(32767)]
        public int MaxLength { get => _inner.MaxLength; set => _inner.MaxLength = value; }

        [Category("Behavior"), DefaultValue(false)]
        public bool ReadOnly
        {
            get => _inner.ReadOnly;
            set { _inner.ReadOnly = value; _inner.BackColor = Theme.SurfaceHigh; Cursor = value ? Cursors.Default : Cursors.IBeam; }
        }

        [Category("Appearance"), DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign { get => _inner.TextAlign; set => _inner.TextAlign = value; }

        [Category("Behavior"), DefaultValue('\0')]
        public char PasswordChar { get => _inner.PasswordChar; set => _inner.PasswordChar = value; }

        [Category("RestoOS"), DefaultValue(8)]
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }

        [Category("RestoOS"), DefaultValue(false)]
        [Description("Texto grande (para montos).")]
        public bool LargeText
        {
            get => _inner.Font.Size > 12;
            set { _inner.Font = value ? Theme.GetFont(15F, FontStyle.Bold) : Theme.GetFont(9.75F); LayoutInner(); }
        }

        [Browsable(false)]
        public TextBox InnerTextBox => _inner;

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set { } }

        public void SelectAll() => _inner.SelectAll();
        public new bool Focus() => _inner.Focus();
        public void Clear() => _inner.Clear();

        // ===================== Layout y pintado =====================

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            LayoutInner();
        }

        protected override void OnPaddingChanged(EventArgs e) { base.OnPaddingChanged(e); LayoutInner(); }

        private void LayoutInner()
        {
            if (_inner == null) return;
            int w = Math.Max(10, Width - Padding.Horizontal);
            if (_inner.Multiline)
            {
                _inner.SetBounds(Padding.Left, Padding.Top, w, Math.Max(10, Height - Padding.Vertical));
            }
            else
            {
                int h = _inner.PreferredHeight;
                _inner.SetBounds(Padding.Left, Math.Max(0, (Height - h) / 2), w, h);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _inner.Focus();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            _inner.Enabled = Enabled;
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            UiHelpers.FillRounded(e.Graphics, Theme.SurfaceHigh, ClientRectangle, _cornerRadius);
            if (_inner.Focused && !_inner.ReadOnly)
                UiHelpers.DrawRounded(e.Graphics, Theme.Primary, ClientRectangle, _cornerRadius, 1f);
        }
    }
}
