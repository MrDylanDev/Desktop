using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Views.Kds;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Cocina KDS (migración de KdsView.xaml de WPF): tres columnas Nuevo → En preparación → Listo.
    /// Las columnas y una tarjeta de ejemplo están en el diseñador; los pedidos (DEMO) se cargan aquí.
    /// </summary>
    public partial class KdsForm : Form
    {
        private readonly List<KdsOrder> _orders = new List<KdsOrder>();

        public KdsForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            LoadMock();
            cmbStation.SelectedIndex = 0; // dispara RefreshAll
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            clockTimer.Start();
        }

        private void LoadMock()
        {
            var now = DateTime.Now;
            _orders.Add(new KdsOrder("Mesa 2", "Parrilla", now.AddMinutes(-4), new KdsItem("x1 Bife de Chorizo 400g", "término medio"), new KdsItem("x1 Cerveza Tirada IPA", "")));
            _orders.Add(new KdsOrder("Mesa 3", "Parrilla", now.AddMinutes(-11), new KdsItem("x2 Hamburguesa Doble Queso", "sin cebolla"), new KdsItem("x1 Limonada Menta", "")) { Status = KdsStatus.Preparacion });
            _orders.Add(new KdsOrder("Barra 1", "Barra", now.AddMinutes(-2), new KdsItem("x2 Cerveza Tirada IPA", ""), new KdsItem("x1 Tiramisú Casero", "extra salsa")));
            _orders.Add(new KdsOrder("Mesa 5", "Fría", now.AddMinutes(-7), new KdsItem("x1 Ensalada César con Pollo", "sin crutones"), new KdsItem("x1 Ravioles 4 Quesos", "")) { Status = KdsStatus.Listo });
        }

        private void RefreshAll()
        {
            string station = cmbStation.SelectedItem?.ToString() ?? "Todas las estaciones";
            var visible = _orders.Where(o => station == "Todas las estaciones" || o.Station == station).ToList();

            Fill(listNuevo, visible.Where(o => o.Status == KdsStatus.Nuevo));
            Fill(listPrep, visible.Where(o => o.Status == KdsStatus.Preparacion));
            Fill(listListo, visible.Where(o => o.Status == KdsStatus.Listo));

            badgeNuevo.Text = visible.Count(o => o.Status == KdsStatus.Nuevo).ToString();
            badgePrep.Text = visible.Count(o => o.Status == KdsStatus.Preparacion).ToString();
            badgeListo.Text = visible.Count(o => o.Status == KdsStatus.Listo).ToString();
            lblPending.Text = visible.Count(o => o.Status != KdsStatus.Listo) + " pendientes";
        }

        private void Fill(RFlowPanel list, IEnumerable<KdsOrder> orders)
        {
            list.SuspendLayout();
            foreach (Control c in list.Controls.Cast<Control>().ToList()) c.Dispose();
            list.Controls.Clear();
            foreach (var o in orders)
            {
                var card = new KdsOrderCard { Width = CardWidth(list) };
                card.SetOrder(o);
                card.BackClicked += Card_BackClicked;
                card.ForwardClicked += Card_ForwardClicked;
                list.Controls.Add(card);
            }
            list.ResumeLayout(true);
        }

        private static int CardWidth(Control list) => Math.Max(200, list.ClientSize.Width - 4);

        private void Card_BackClicked(object sender, EventArgs e)
        {
            var o = ((KdsOrderCard)sender).Order;
            o.Status = o.Status == KdsStatus.Listo ? KdsStatus.Preparacion : KdsStatus.Nuevo;
            BeginInvoke(new Action(RefreshAll));
        }

        private void Card_ForwardClicked(object sender, EventArgs e)
        {
            var o = ((KdsOrderCard)sender).Order;
            if (o.Status == KdsStatus.Nuevo) o.Status = KdsStatus.Preparacion;
            else if (o.Status == KdsStatus.Preparacion) o.Status = KdsStatus.Listo;
            else _orders.Remove(o); // entregado
            BeginInvoke(new Action(RefreshAll));
        }

        private void CmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) RefreshAll();
        }

        private void List_Resize(object sender, EventArgs e)
        {
            var list = (Control)sender;
            foreach (Control c in list.Controls) c.Width = CardWidth(list);
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            foreach (var list in new Control[] { listNuevo, listPrep, listListo })
                foreach (Control c in list.Controls)
                    if (c is KdsOrderCard card) card.RefreshElapsed();
        }
    }
}
