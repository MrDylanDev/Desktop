using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>Variantes de botón: cada una es un Style de App.xaml (WPF).</summary>
    public enum ButtonVariant
    {
        /// <summary>PrimaryButton: melocotón con texto oscuro (COBRAR, Guardar).</summary>
        Primary,
        /// <summary>SecondaryButton: gris (Cancelar, Vaciar pedido).</summary>
        Secondary,
        /// <summary>IconButton: gris compacto y en negrita (+, −).</summary>
        Icon,
        /// <summary>DangerButton: rojo oscuro (×, C).</summary>
        Danger,
        /// <summary>NavButton: transparente, alineado a la izquierda (sidebar).</summary>
        Nav,
        /// <summary>NumpadButton: gris grande (teclado de cobro).</summary>
        Numpad,
        /// <summary>Chip seleccionable (Efectivo / Tarjeta).</summary>
        Toggle
    }

    /// <summary>
    /// Botón temático RestoOS. Arrástralo desde el Cuadro de herramientas y elige <see cref="Variant"/>.
    /// Pinta esquinas redondeadas suaves, hover y deshabilitado igual que los estilos WPF.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("Click")]
    [Description("Botón temático RestoOS (Primary, Secondary, Danger, Nav, Numpad...).")]
    public class RButton : Control, IButtonControl
    {
        private ButtonVariant _variant = ButtonVariant.Primary;
        private int _cornerRadius = -1;
        private bool _selected;
        private bool _hover;
        private bool _pressed;
        private ContentAlignment _textAlign = ContentAlignment.MiddleCenter;
        private DialogResult _dialogResult = DialogResult.None;
        private bool _isDefault;
        private bool _compact;

        public RButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable |
                     ControlStyles.StandardClick, true);
            SetStyle(ControlStyles.StandardDoubleClick, false);
            base.BackColor = Color.Transparent;
            Cursor = Cursors.Hand;
            Size = new Size(140, 40);
            ApplyVariantFont();
        }

        // ===================== Propiedades de diseño =====================

        [Category("RestoOS"), DefaultValue(ButtonVariant.Primary)]
        [Description("Estilo del botón (equivale a Style=\"{StaticResource ...}\" en WPF).")]
        public ButtonVariant Variant
        {
            get => _variant;
            set
            {
                _variant = value;
                if (value == ButtonVariant.Nav && _textAlign == ContentAlignment.MiddleCenter) _textAlign = ContentAlignment.MiddleLeft;
                ApplyVariantFont();
                Invalidate();
            }
        }

        [Category("RestoOS"), DefaultValue(-1)]
        [Description("Radio de esquinas. -1 = el de la variante (8 ó 10).")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        [Category("RestoOS"), DefaultValue(false)]
        [Description("Texto más pequeño (botones de 30px dentro de tarjetas).")]
        public bool Compact
        {
            get => _compact;
            set { _compact = value; ApplyVariantFont(); Invalidate(); }
        }

        [Category("RestoOS"), DefaultValue(false)]
        [Description("Marca el botón como activo (página actual en el sidebar, chip elegido).")]
        public bool Selected
        {
            get => _selected;
            set { _selected = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment TextAlign
        {
            get => _textAlign;
            set { _textAlign = value; Invalidate(); }
        }

        [Category("Behavior"), DefaultValue(DialogResult.None)]
        public DialogResult DialogResult
        {
            get => _dialogResult;
            set => _dialogResult = value;
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set { base.Text = value; Invalidate(); }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set { } }

        protected override Padding DefaultPadding => new Padding(12, 6, 12, 6);

        // ===================== IButtonControl =====================

        public void NotifyDefault(bool value)
        {
            _isDefault = value;
            Invalidate();
        }

        public void PerformClick()
        {
            if (CanSelect || Enabled) OnClick(EventArgs.Empty);
        }

        protected override void OnClick(EventArgs e)
        {
            if (!Enabled) return;
            var form = FindForm();
            if (form != null && _dialogResult != DialogResult.None) form.DialogResult = _dialogResult;
            base.OnClick(e);
        }

        // ===================== Interacción =====================

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnEnabledChanged(EventArgs e) { Cursor = Enabled ? Cursors.Hand : Cursors.Default; Invalidate(); base.OnEnabledChanged(e); }
        protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
        protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }
        protected override void OnFontChanged(EventArgs e) { Invalidate(); base.OnFontChanged(e); }

        protected override bool IsInputKey(Keys keyData) => keyData == Keys.Space || keyData == Keys.Enter || base.IsInputKey(keyData);

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) { PerformClick(); e.Handled = true; }
            base.OnKeyUp(e);
        }

        // ===================== Pintado =====================

        private void ApplyVariantFont()
        {
            if (_compact)
            {
                bool bold = _variant == ButtonVariant.Primary || _variant == ButtonVariant.Danger || _variant == ButtonVariant.Icon;
                base.Font = Theme.GetFont(8.25F, bold ? FontStyle.Bold : FontStyle.Regular);
                return;
            }
            switch (_variant)
            {
                case ButtonVariant.Primary: base.Font = Theme.GetFont(10.5F, FontStyle.Bold); break;
                case ButtonVariant.Icon: base.Font = Theme.GetFont(10.5F, FontStyle.Bold); break;
                case ButtonVariant.Danger: base.Font = Theme.GetFont(10.5F, FontStyle.Bold); break;
                case ButtonVariant.Numpad: base.Font = Theme.GetFont(13.5F, FontStyle.Bold); break;
                case ButtonVariant.Nav: base.Font = Theme.GetFont(10.5F); break;
                case ButtonVariant.Toggle: base.Font = Theme.GetFont(9.75F, FontStyle.Bold); break;
                default: base.Font = Theme.GetFont(9.75F); break;
            }
        }

        private int Radius => _cornerRadius >= 0 ? _cornerRadius : (_variant == ButtonVariant.Primary ? 10 : 8);

        private void GetColors(out Color bg, out Color fg)
        {
            switch (_variant)
            {
                case ButtonVariant.Primary:
                    bg = Theme.Primary; fg = Theme.OnPrimary;
                    if (_hover) bg = Theme.Blend(Theme.Primary, UiHelpers.EffectiveBackColor(this), 0.88);
                    if (_pressed) bg = Theme.Blend(Theme.Primary, UiHelpers.EffectiveBackColor(this), 0.78);
                    break;
                case ButtonVariant.Danger:
                    bg = _hover || _pressed ? Theme.ErrorContainerHover : Theme.ErrorContainer; fg = Theme.Error;
                    break;
                case ButtonVariant.Nav:
                    bg = _selected || _hover ? Theme.SurfaceHigh : Color.Transparent; fg = Theme.OnSurface;
                    if (_pressed) bg = Theme.SurfaceHighest;
                    break;
                case ButtonVariant.Toggle:
                    if (_selected) { bg = Theme.Primary; fg = Theme.OnPrimary; }
                    else { bg = _hover ? Theme.SurfaceHighest : Theme.SurfaceHigh; fg = Theme.OnSurface; }
                    break;
                default: // Secondary, Icon, Numpad
                    bg = _hover || _pressed || _selected ? Theme.SurfaceHighest : Theme.SurfaceHigh; fg = Theme.OnSurface;
                    break;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var parentColor = UiHelpers.EffectiveBackColor(this);
            GetColors(out var bg, out var fg);

            if (!Enabled)
            {
                double opacity = _variant == ButtonVariant.Primary ? 0.35 : 0.45;
                if (bg.A > 0) bg = Theme.Blend(bg, parentColor, opacity);
                fg = Theme.Blend(fg, parentColor, opacity);
            }

            if (bg.A > 0) UiHelpers.FillRounded(e.Graphics, bg, ClientRectangle, Radius);

            if (Focused && ShowFocusCues && Enabled)
                UiHelpers.DrawRounded(e.Graphics, Theme.Blend(Theme.Primary, parentColor, 0.7), ClientRectangle, Radius, 1.5f);
            else if (_isDefault && _variant != ButtonVariant.Primary && Enabled)
                UiHelpers.DrawRounded(e.Graphics, Theme.Outline, ClientRectangle, Radius, 1f);

            var rect = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Horizontal, Height - Padding.Vertical);
            TextRenderer.DrawText(e.Graphics, Text, Font, rect, fg, ToFlags(_textAlign) | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
        }

        private static TextFormatFlags ToFlags(ContentAlignment a)
        {
            TextFormatFlags f = TextFormatFlags.SingleLine;
            switch (a)
            {
                case ContentAlignment.TopLeft: return f | TextFormatFlags.Top | TextFormatFlags.Left;
                case ContentAlignment.TopCenter: return f | TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                case ContentAlignment.TopRight: return f | TextFormatFlags.Top | TextFormatFlags.Right;
                case ContentAlignment.MiddleLeft: return f | TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                case ContentAlignment.MiddleRight: return f | TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                case ContentAlignment.BottomLeft: return f | TextFormatFlags.Bottom | TextFormatFlags.Left;
                case ContentAlignment.BottomCenter: return f | TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                case ContentAlignment.BottomRight: return f | TextFormatFlags.Bottom | TextFormatFlags.Right;
                default: return f | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
            }
        }
    }
}
