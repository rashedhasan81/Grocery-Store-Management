using System;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();

            // ── Wire ALL events here ──────────────
            btnProducts.Click += btnProducts_Click;
            btnProducts.MouseEnter += NavBtn_MouseEnter;
            btnProducts.MouseLeave += NavBtn_MouseLeave;

            btnCart.Click += btnCart_Click;
            btnCart.MouseEnter += NavBtn_MouseEnter;
            btnCart.MouseLeave += NavBtn_MouseLeave;

            btnOrders.Click += btnOrders_Click;
            btnOrders.MouseEnter += NavBtn_MouseEnter;
            btnOrders.MouseLeave += NavBtn_MouseLeave;

            btnProfile.Click += btnProfile_Click;
            btnProfile.MouseEnter += NavBtn_MouseEnter;
            btnProfile.MouseLeave += NavBtn_MouseLeave;

            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += NavBtn_MouseEnter;
            btnLogout.MouseLeave += NavBtn_MouseLeave;

            // Defer runtime-only work to the Load event so the Designer can instantiate the form
            this.Load += CustomerDashboard_Load;
        }

        // Load event runs at runtime; guard against design-time rendering
        private void CustomerDashboard_Load(object? sender, EventArgs e)
        {
            // Designer hosts set UsageMode to Designtime — skip DB work there
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // Now it's safe to run runtime-only initialization
            LoadDashboardData();
            LoadOrders();
        }

        // ================= DASHBOARD CARDS =================

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("SELECT COUNT(*) FROM Products", con))
                        lblCard1Count.Text = cmd.ExecuteScalar().ToString();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "SELECT ISNULL(SUM(Quantity),0) FROM Cart WHERE username=@u", con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);
                        lblCard2Count.Text = cmd.ExecuteScalar().ToString();
                    }

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Orders WHERE username=@u", con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);
                        lblCard3Count.Text = cmd.ExecuteScalar().ToString();
                    }

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Orders WHERE username=@u AND Status<>'Delivered'", con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);
                        lblCard4Count.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= LOAD ORDERS =================

        private void LoadOrders()
        {
            dataGridViewOrders.Rows.Clear();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query =
                        @"SELECT
                            o.OrderId,
                            o.OrderDate,
                            STRING_AGG(p.ProductName, ', ') AS Products,
                            o.TotalAmount,
                            o.Status
                          FROM Orders o
                          INNER JOIN OrderItems oi ON o.OrderId    = oi.OrderId
                          INNER JOIN Products   p  ON oi.ProductId = p.ProductId
                          WHERE o.username = @u
                          GROUP BY
                            o.OrderId, o.OrderDate,
                            o.TotalAmount, o.Status
                          ORDER BY o.OrderDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridViewOrders.Rows.Add(
                                    "#ORD-" + reader["OrderId"],
                                    Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd"),
                                    reader["Products"].ToString(),
                                    "৳ " + reader["TotalAmount"],
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orders error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ColorStatus();
        }

        // ================= STATUS COLORS =================

        private void ColorStatus()
        {
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.IsNewRow) continue;

                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                Color bg, fg;

                switch (status)
                {
                    case "Delivered":
                        bg = Color.FromArgb(212, 240, 220);
                        fg = Color.FromArgb(26, 96, 48);
                        break;
                    case "In Transit":
                        bg = Color.FromArgb(254, 243, 208);
                        fg = Color.FromArgb(122, 86, 0);
                        break;
                    case "Processing":
                        bg = Color.FromArgb(214, 234, 252);
                        fg = Color.FromArgb(20, 70, 140);
                        break;
                    case "Cancelled":
                        bg = Color.FromArgb(253, 232, 232);
                        fg = Color.FromArgb(140, 32, 32);
                        break;
                    default:
                        bg = Color.FromArgb(235, 235, 235);
                        fg = Color.FromArgb(80, 80, 80);
                        break;
                }

                row.Cells["colStatus"].Style.BackColor = bg;
                row.Cells["colStatus"].Style.ForeColor = fg;
                row.Cells["colStatus"].Style.SelectionBackColor = bg;
                row.Cells["colStatus"].Style.SelectionForeColor = fg;
                row.Cells["colStatus"].Style.Font =
                    new Font("Segoe UI", 9f, FontStyle.Bold);
            }
        }

        // ================= BUTTON CLICKS =================

        private void btnProducts_Click(object sender, EventArgs e)
            => new ProductForm().Show();

        private void btnCart_Click(object sender, EventArgs e)
            => new CartForm().Show();

        private void btnOrders_Click(object sender, EventArgs e)
            => new OrdersForm().Show();

        private void btnProfile_Click(object sender, EventArgs e)
            => new ProfileForm().Show();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        // ================= HOVER EFFECTS =================

        private void NavBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = Color.FromArgb(34, 139, 87);
        }

        private void NavBtn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = (b == btnLogout)
                    ? Color.FromArgb(200, 50, 50)
                    : Color.FromArgb(44, 160, 100);
        }
    }
}