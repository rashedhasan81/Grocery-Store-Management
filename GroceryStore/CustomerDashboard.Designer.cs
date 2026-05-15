using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class CustomerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCard1Count, lblCard2Count, lblCard3Count, lblCard4Count;
        private Button btnProducts, btnCart, btnOrders, btnProfile, btnLogout;
        private DataGridView dataGridViewOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // ── FORM ─────────────────────────────
            this.Text = "FreshMart — Customer Dashboard";
            this.Size = new Size(1100, 680);
            this.MinimumSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── SIDEBAR ──────────────────────────
            Panel sidebar = new Panel
            {
                Width = 200,
                Dock = DockStyle.Left,          // fills full form height — fixes logout clipping
                BackColor = Color.FromArgb(25, 80, 45)
            };
            this.Controls.Add(sidebar);

            Label lblLogo = new Label
            {
                Text = "🛒  FreshMart",
                Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(200, 56),
                Location = new Point(0, 0),
                TextAlign = ContentAlignment.MiddleCenter
            };
            sidebar.Controls.Add(lblLogo);

            Label lblSep1 = new Label
            {
                Size = new Size(160, 1),
                Location = new Point(20, 58),
                BackColor = Color.FromArgb(55, 120, 80)
            };
            sidebar.Controls.Add(lblSep1);

            // ── NAV BUTTONS ──────────────────────
            btnProducts = CreateNavButton("🛍  Products", 72);
            sidebar.Controls.Add(btnProducts);

            btnCart = CreateNavButton("🛒  My Cart", 122);
            sidebar.Controls.Add(btnCart);

            Label lblSep2 = new Label
            {
                Size = new Size(160, 1),
                Location = new Point(20, 174),
                BackColor = Color.FromArgb(55, 120, 80)
            };
            sidebar.Controls.Add(lblSep2);

            btnOrders = CreateNavButton("📦  My Orders", 180);
            sidebar.Controls.Add(btnOrders);

            btnProfile = CreateNavButton("👤  Profile", 230);
            sidebar.Controls.Add(btnProfile);

            // ── LOGOUT ───────────────────────────
            // Dock to bottom so it is always visible regardless of form height / DPI / scaling
            btnLogout = new Button
            {
                Text = "🚪  Logout",
                Dock = DockStyle.Bottom,
                Height = 56,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(176, 48, 48),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLogout.FlatAppearance.BorderSize = 0;
            sidebar.Controls.Add(btnLogout);

            // ── CONTENT PANEL ────────────────────
            Panel content = new Panel
            {
                Location = new Point(200, 0),
                Size = new Size(900, 680),
                BackColor = Color.FromArgb(244, 248, 245)
            };
            this.Controls.Add(content);

            // ── TOP BAR ──────────────────────────
            Panel topBar = new Panel
            {
                Size = new Size(900, 60),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            content.Controls.Add(topBar);

            Label lblWelcome = new Label
            {
                Text = "Welcome back 👋",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 18),
                AutoSize = true
            };
            topBar.Controls.Add(lblWelcome);

            Label lblDate = new Label
            {
                Text = DateTime.Now.ToString("dddd, MMMM d, yyyy"),
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.Gray,
                Location = new Point(680, 22),
                AutoSize = true
            };
            topBar.Controls.Add(lblDate);

            // ── CARDS ────────────────────────────
            lblCard1Count = CreateCard(content, "🧺", "Total Products", 0, Color.FromArgb(27, 122, 62));
            lblCard2Count = CreateCard(content, "🛒", "Cart Items", 1, Color.FromArgb(37, 99, 170));
            lblCard3Count = CreateCard(content, "📦", "Orders", 2, Color.FromArgb(196, 122, 16));
            lblCard4Count = CreateCard(content, "🚚", "Pending", 3, Color.FromArgb(184, 48, 48));

            // ── SECTION LABEL ────────────────────
            Label lblRecentOrders = new Label
            {
                Text = "RECENT ORDERS",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 240),
                AutoSize = true
            };
            content.Controls.Add(lblRecentOrders);

            // ── DATA GRID ────────────────────────
            dataGridViewOrders = new DataGridView
            {
                Location = new Point(20, 262),
                Size = new Size(858, 376),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(210, 235, 215),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Font = new Font("Segoe UI", 9.5f),
                EnableHeadersVisualStyles = false
            };
            dataGridViewOrders.RowTemplate.Height = 34;
            dataGridViewOrders.ColumnHeadersHeight = 36;
            dataGridViewOrders.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 80, 45);
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dataGridViewOrders.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 250, 245);
            dataGridViewOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 238, 220);
            dataGridViewOrders.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ── COLUMNS ──────────────────────────
            DataGridViewTextBoxColumn colOrderId = new DataGridViewTextBoxColumn();
            colOrderId.Name = "colOrderId";
            colOrderId.HeaderText = "Order ID";
            colOrderId.Width = 90;
            dataGridViewOrders.Columns.Add(colOrderId);

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.Name = "colDate";
            colDate.HeaderText = "Date";
            colDate.Width = 100;
            dataGridViewOrders.Columns.Add(colDate);

            DataGridViewTextBoxColumn colProducts = new DataGridViewTextBoxColumn();
            colProducts.Name = "colProducts";
            colProducts.HeaderText = "Products";
            colProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrders.Columns.Add(colProducts);

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.Name = "colAmount";
            colAmount.HeaderText = "Amount";
            colAmount.Width = 90;
            dataGridViewOrders.Columns.Add(colAmount);

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Status";
            colStatus.Width = 110;
            dataGridViewOrders.Columns.Add(colStatus);

            content.Controls.Add(dataGridViewOrders);

            this.ResumeLayout(false);
        }

        // ── Helper: Nav Button ────────────────
        // Moved here from CustomerDashboard.cs so the Designer can resolve it
        private Button CreateNavButton(string text, int y)
        {
            Button b = new Button
            {
                Text = text,
                Size = new Size(200, 46),
                Location = new Point(0, y),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(44, 160, 100),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(16, 0, 0, 0),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        // ── Helper: Card ─────────────────────
        // Moved here from CustomerDashboard.cs so the Designer can resolve it
        private Label CreateCard(Control parent, string icon,
                                 string title, int index, Color color)
        {
            Panel card = new Panel
            {
                Size = new Size(200, 110),
                Location = new Point(20 + index * 215, 74),
                BackColor = Color.White
            };

            Label ic = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 20f),
                Location = new Point(14, 14),
                AutoSize = true
            };

            Label count = new Label
            {
                Text = "—",
                Font = new Font("Segoe UI", 24f, FontStyle.Bold),
                ForeColor = color,
                Location = new Point(68, 14),
                AutoSize = true
            };

            Label lbl = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.Gray,
                Location = new Point(14, 78),
                AutoSize = true
            };

            card.Controls.Add(ic);
            card.Controls.Add(count);
            card.Controls.Add(lbl);
            parent.Controls.Add(card);

            return count;
        }
    }
}