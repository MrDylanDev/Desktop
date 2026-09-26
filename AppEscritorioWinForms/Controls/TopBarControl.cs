using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Controls
{
    public partial class TopBarControl : UserControl
    {
        private Label lblClock;
        private Label lblRoute;
        private Label lblRoleBadge;
        private Button btnCambiarPerfil;
        private System.Windows.Forms.Timer clockTimer;

        public event EventHandler CambiarPerfilClicked;

        public string PageTitle
        {
            get => lblRoute.Text;
            set => lblRoute.Text = value;
        }

        public string RoleText
        {
            get => lblRoleBadge.Text;
            set => lblRoleBadge.Text = value;
        }

        public TopBarControl()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Height = 54;
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(25, 25, 30);

            // Bottom border
            Panel pnlBorder = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 55)
            };
            this.Controls.Add(pnlBorder);

            // Left Side container
            Panel pnlLeft = new Panel { Dock = DockStyle.Left, Width = 400 };

            lblClock = new Label
            {
                Font = new Font("Consolas", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(40, 40, 48),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(100, 30),
                Location = new Point(15, 12)
            };

            lblRoute = new Label
            {
                Font = new Font("Segoe UI", 13F),
                ForeColor = Color.FromArgb(160, 160, 160),
                Location = new Point(130, 14),
                AutoSize = true
            };

            pnlLeft.Controls.Add(lblClock);
            pnlLeft.Controls.Add(lblRoute);
            this.Controls.Add(pnlLeft);

            // Right Side container
            Panel pnlRight = new Panel { Dock = DockStyle.Right, Width = 450 };

            lblRoleBadge = new Label
            {
                BackColor = Color.FromArgb(40, 30, 10),
                ForeColor = Color.FromArgb(243, 146, 0),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(120, 26),
                Location = new Point(20, 14)
            };

            Label lblRestoOS = new Label
            {
                Text = "RestoOS",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 11F),
                AutoSize = true,
                Location = new Point(155, 16)
            };

            Label lblOrangeCircle = new Label
            {
                Text = "🟠",
                ForeColor = Color.FromArgb(243, 146, 0),
                Font = new Font("Segoe UI", 12F),
                AutoSize = true,
                Location = new Point(225, 14)
            };

            btnCambiarPerfil = new Button
            {
                Text = "↩ Cambiar perfil",
                ForeColor = Color.White,
                BackColor = Color.FromArgb(35, 35, 40),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(140, 30),
                Location = new Point(280, 12),
                Cursor = Cursors.Hand
            };
            btnCambiarPerfil.FlatAppearance.BorderSize = 0;
            btnCambiarPerfil.Click += (s, e) => CambiarPerfilClicked?.Invoke(this, EventArgs.Empty);

            pnlRight.Controls.Add(lblRoleBadge);
            pnlRight.Controls.Add(lblRestoOS);
            pnlRight.Controls.Add(lblOrangeCircle);
            pnlRight.Controls.Add(btnCambiarPerfil);

            this.Controls.Add(pnlRight);

            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => UpdateClock();
            clockTimer.Start();
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (clockTimer != null)
                {
                    clockTimer.Stop();
                    clockTimer.Dispose();
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}