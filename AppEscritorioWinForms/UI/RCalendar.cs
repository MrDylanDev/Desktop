using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.UI
{
    /// <summary>Calendario mensual oscuro (el MonthCalendar de Windows no se puede oscurecer).</summary>
    [ToolboxItem(true)]
    [DefaultEvent("DateChanged")]
    [Description("Calendario temático RestoOS.")]
    public class RCalendar : Control
    {
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");
        private DateTime _selected = DateTime.Today;
        private DateTime _month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        private Point _hover = new Point(-1, -1);

        public event EventHandler DateChanged;

        public RCalendar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            Size = new Size(300, 280);
            Cursor = Cursors.Hand;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime SelectedDate
        {
            get => _selected;
            set
            {
                _selected = value.Date;
                _month = new DateTime(_selected.Year, _selected.Month, 1);
                Invalidate();
                DateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        private const int HeaderH = 36, DowH = 24;
        private int CellW => Math.Max(1, Width / 7);
        private int CellH => Math.Max(1, (Height - HeaderH - DowH) / 6);
        private Rectangle PrevRect => new Rectangle(0, 0, 32, HeaderH);
        private Rectangle NextRect => new Rectangle(Width - 32, 0, 32, HeaderH);

        private DateTime FirstCell
        {
            get
            {
                int offset = ((int)_month.DayOfWeek + 6) % 7; // semana empieza el lunes
                return _month.AddDays(-offset);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            string title = Co.TextInfo.ToTitleCase(_month.ToString("MMMM yyyy", Co));
            TextRenderer.DrawText(g, title, Theme.GetFont(10.5F, FontStyle.Bold), new Rectangle(0, 0, Width, HeaderH), Theme.OnSurface,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            TextRenderer.DrawText(g, "‹", Theme.GetFont(14F, FontStyle.Bold), PrevRect, Theme.Secondary, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            TextRenderer.DrawText(g, "›", Theme.GetFont(14F, FontStyle.Bold), NextRect, Theme.Secondary, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            string[] dow = { "lu", "ma", "mi", "ju", "vi", "sá", "do" };
            for (int i = 0; i < 7; i++)
                TextRenderer.DrawText(g, dow[i], Theme.GetFont(8.25F, FontStyle.Bold), new Rectangle(i * CellW, HeaderH, CellW, DowH),
                    Theme.OnSurfaceVariant, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            var day = FirstCell;
            for (int r = 0; r < 6; r++)
                for (int c = 0; c < 7; c++, day = day.AddDays(1))
                {
                    var cell = new Rectangle(c * CellW + 2, HeaderH + DowH + r * CellH + 2, CellW - 4, CellH - 4);
                    bool inMonth = day.Month == _month.Month;
                    bool isSel = day == _selected;
                    bool isToday = day == DateTime.Today;
                    if (isSel) UiHelpers.FillRounded(g, Theme.Primary, cell, 8);
                    else if (_hover == new Point(c, r)) UiHelpers.FillRounded(g, Theme.SurfaceHigh, cell, 8);
                    else if (isToday) UiHelpers.DrawRounded(g, Theme.Secondary, cell, 8, 1f);
                    var fg = isSel ? Theme.OnPrimary : inMonth ? Theme.OnSurface : Theme.Blend(Theme.OnSurfaceVariant, UiHelpers.EffectiveBackColor(this), 0.45);
                    TextRenderer.DrawText(g, day.Day.ToString(), Theme.GetFont(9.75F, isSel ? FontStyle.Bold : FontStyle.Regular), cell, fg,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var p = HitCell(e.Location);
            if (p != _hover) { _hover = p; Invalidate(); }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hover = new Point(-1, -1);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (PrevRect.Contains(e.Location)) { _month = _month.AddMonths(-1); Invalidate(); return; }
            if (NextRect.Contains(e.Location)) { _month = _month.AddMonths(1); Invalidate(); return; }
            var p = HitCell(e.Location);
            if (p.X >= 0) SelectedDate = FirstCell.AddDays(p.Y * 7 + p.X);
        }

        private Point HitCell(Point pt)
        {
            if (pt.Y < HeaderH + DowH) return new Point(-1, -1);
            int c = pt.X / CellW, r = (pt.Y - HeaderH - DowH) / CellH;
            return c >= 0 && c < 7 && r >= 0 && r < 6 ? new Point(c, r) : new Point(-1, -1);
        }
    }

    /// <summary>Gráfico de barras simple (ventas por día). En el diseñador muestra datos de ejemplo.</summary>
    [ToolboxItem(true)]
    [Description("Gráfico de barras temático RestoOS.")]
    public class RBarChart : Control
    {
        private decimal[] _values = { 100, 150, 120, 180, 200, 250, 160 };
        private string[] _labels = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };

        public RBarChart()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            Size = new Size(400, 160);
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set { } }

        /// <summary>Asigna los valores y etiquetas (mismo largo). El último se resalta.</summary>
        public void SetData(decimal[] values, string[] labels)
        {
            _values = values ?? new decimal[0];
            _labels = labels ?? new string[0];
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e) => e.Graphics.Clear(UiHelpers.EffectiveBackColor(this));

        protected override void OnPaint(PaintEventArgs e)
        {
            int n = _values.Length;
            if (n == 0) return;
            decimal max = 0; foreach (var v in _values) if (v > max) max = v;
            int labelH = 20, colW = Width / n, barW = Math.Max(8, colW - 24);
            for (int i = 0; i < n; i++)
            {
                int h = max > 0 ? (int)((Height - labelH - 4) * (double)(_values[i] / max)) : 0;
                h = Math.Max(6, h);
                var r = new Rectangle(i * colW + (colW - barW) / 2, Height - labelH - h, barW, h);
                UiHelpers.FillRounded(e.Graphics, i == n - 1 ? Theme.PrimaryContainer : Theme.Primary, r, 6);
                if (i < _labels.Length)
                    TextRenderer.DrawText(e.Graphics, _labels[i], Theme.GetFont(8.25F), new Rectangle(i * colW, Height - labelH, colW, labelH),
                        Theme.OnSurfaceVariant, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
