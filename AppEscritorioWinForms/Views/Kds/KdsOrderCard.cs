using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Views.Kds
{
    /// <summary>
    /// Tarjeta de pedido del KDS: mesa, tiempo transcurrido, platos con notas y botones para mover de columna.
    /// <see cref="Stage"/> cambia el color del borde y los botones (Nuevo / En preparación / Listo).
    /// </summary>
    [ToolboxItem(true)]
    public partial class KdsOrderCard : RCardControl
    {
        private KdsStatus _stage = KdsStatus.Nuevo;

        /// <summary>Botón izquierdo (volver una columna).</summary>
        public event EventHandler BackClicked;
        /// <summary>Botón principal (avanzar / entregar).</summary>
        public event EventHandler ForwardClicked;

        public KdsOrderCard()
        {
            InitializeComponent();
            ApplyStage();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KdsOrder Order { get; private set; }

        [Category("RestoOS"), DefaultValue(KdsStatus.Nuevo), Description("Columna de la tarjeta (color y botones).")]
        public KdsStatus Stage
        {
            get => _stage;
            set { _stage = value; ApplyStage(); }
        }

        [Category("RestoOS"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Mesa { get => lblMesa.Text; set => lblMesa.Text = value; }

        public static Color StageColor(KdsStatus s) =>
            s == KdsStatus.Nuevo ? Theme.Secondary : s == KdsStatus.Preparacion ? Theme.Primary : Theme.Tertiary;

        public void SetOrder(KdsOrder order)
        {
            Order = order;
            lblMesa.Text = order.Mesa;
            lblCreated.Text = order.CreatedText;
            Stage = order.Status;
            RefreshElapsed();

            pnlItems.SuspendLayout();
            foreach (Control c in pnlItems.Controls) c.Dispose();
            pnlItems.Controls.Clear();
            foreach (var item in order.Items)
            {
                pnlItems.Controls.Add(NewLine(item.Line, TextStyle.Body));
                if (!string.IsNullOrWhiteSpace(item.Note)) pnlItems.Controls.Add(NewLine(item.Note, TextStyle.AccentSmall));
            }
            pnlItems.ResumeLayout(false);
            Relayout();
        }

        public void RefreshElapsed()
        {
            if (Order == null) return;
            lblElapsed.Text = Order.Elapsed;
            lblElapsed.ColorOverride = Order.ElapsedColor;
        }

        private static RLabel NewLine(string text, TextStyle style) =>
            new RLabel { Text = text, TextStyle = style, AutoSize = true, Margin = Padding.Empty };

        private void ApplyStage()
        {
            BorderColor = StageColor(_stage);
            switch (_stage)
            {
                case KdsStatus.Nuevo:
                    btnBack.Visible = false;
                    btnForward.Text = "▶  Preparar";
                    btnForward.Variant = ButtonVariant.Primary;
                    break;
                case KdsStatus.Preparacion:
                    btnBack.Visible = true;
                    btnBack.Text = "◀ Nuevo";
                    btnForward.Text = "✓ Listo";
                    btnForward.Variant = ButtonVariant.Primary;
                    break;
                default:
                    btnBack.Visible = true;
                    btnBack.Text = "↺ Preparación";
                    btnForward.Text = "✓ Entregado";
                    btnForward.Variant = ButtonVariant.Danger;
                    break;
            }
            Relayout();
        }

        /// <summary>Acomoda platos y botones al ancho actual y ajusta el alto de la tarjeta.</summary>
        private void Relayout()
        {
            if (btnForward == null) return;
            int w = Math.Max(60, ClientSize.Width - 24);
            int y = 0;
            foreach (Control c in pnlItems.Controls)
            {
                if (c is RLabel l) l.MaximumSize = new Size(w, 0);
                c.Location = new Point(c is RLabel rl && rl.TextStyle == TextStyle.AccentSmall ? 8 : 0, y);
                y += c.Height + 4;
            }
            pnlItems.SetBounds(12, 58, w, Math.Max(y, 4));

            int by = pnlItems.Bottom + 8;
            if (btnBack.Visible)
            {
                int half = (w - 12) / 2;
                btnBack.SetBounds(12, by, half, 36);
                btnForward.SetBounds(12 + half + 12, by, w - half - 12, 36);
            }
            else btnForward.SetBounds(12, by, w, 36);
            Height = by + 36 + 12;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Relayout();
        }

        private void BtnBack_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
        private void BtnForward_Click(object sender, EventArgs e) => ForwardClicked?.Invoke(this, EventArgs.Empty);
    }
}
