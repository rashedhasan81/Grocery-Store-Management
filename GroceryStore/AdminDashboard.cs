using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class AdminDashboard : Form
    {
        private Button _activeNav;

        public AdminDashboard()
        {
            InitializeComponent();

            _activeNav = btnNavDashboard;

            LoadDashboardStats();
            LoadOrders();
            LoadLowStock();
        }

        // ─────────────────────────────────────────────
        // DASHBOARD STATS
        // ─────────────────────────────────────────────
        private void LoadDashboardStats()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    // Total Products
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products", con))
                        lblC1Value.Text = cmd.ExecuteScalar().ToString();

                    // Total Orders
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", con))
                        lblC2Value.Text = cmd.ExecuteScalar().ToString();

                    // Revenue
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(TotalAmount),0) FROM Orders", con))
                        lblC3Value.Text = "৳" + cmd.ExecuteScalar().ToString();

                    // 🔴 Low Stock Alert (<=20)
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock <= 20", con))
                    {
                        int lowStock = Convert.ToInt32(cmd.ExecuteScalar());

                        lblC4Value.Text = lowStock.ToString();

                        if (lowStock > 0)
                        {
                            lblC4Value.ForeColor = Color.Red;
                            lblC4Value.Text += " ⚠ Restock Needed";
                        }
                        else
                        {
                            lblC4Value.ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error:\n" + ex.Message);
            }
        }

        // ─────────────────────────────────────────────
        // LOAD ORDERS
        // ─────────────────────────────────────────────
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            o.OrderId,
                            o.username,
                            STRING_AGG(p.ProductName, ', ') AS Items,
                            o.TotalAmount,
                            o.OrderDate,
                            o.Status
                        FROM Orders o
                        INNER JOIN OrderItems oi ON o.OrderId = oi.OrderId
                        INNER JOIN Products p ON oi.ProductId = p.ProductId
                        GROUP BY 
                            o.OrderId, o.username, o.TotalAmount, o.OrderDate, o.Status
                        ORDER BY o.OrderDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }

                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orders error:\n" + ex.Message);
            }
        }

        // ─────────────────────────────────────────────
        // GRID FORMAT
        // ─────────────────────────────────────────────
        private void FormatGrid()
        {
            if (dgvOrders.Columns.Count == 0) return;

            dgvOrders.Columns["OrderId"].HeaderText = "Order ID";
            dgvOrders.Columns["username"].HeaderText = "Customer";
            dgvOrders.Columns["Items"].HeaderText = "Items";
            dgvOrders.Columns["TotalAmount"].HeaderText = "Total";
            dgvOrders.Columns["OrderDate"].HeaderText = "Date";
            dgvOrders.Columns["Status"].HeaderText = "Status";

            dgvOrders.CellFormatting += dgvOrders_CellFormatting;
        }

        // ─────────────────────────────────────────────
        // STATUS COLOR
        // ─────────────────────────────────────────────
        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "Delivered":
                        e.CellStyle.ForeColor = Color.Green; break;
                    case "Processing":
                        e.CellStyle.ForeColor = Color.Orange; break;
                    case "Shipped":
                        e.CellStyle.ForeColor = Color.Blue; break;
                    case "Cancelled":
                        e.CellStyle.ForeColor = Color.Red; break;
                }
            }
        }

        // ─────────────────────────────────────────────
        // LOW STOCK LIST
        // ─────────────────────────────────────────────
        private void LoadLowStock()
        {
            lstStock.Items.Clear();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = "SELECT ProductName, Stock FROM Products WHERE Stock <= 20";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int stock = Convert.ToInt32(dr["Stock"]);

                        string status = stock <= 5 ? "🔴 Urgent"
                                        : stock <= 10 ? "🟠 Low"
                                        : "🟡 Running Low";

                        lstStock.Items.Add($"{dr["ProductName"]}   Qty: {stock}   {status}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock error:\n" + ex.Message);
            }
        }

        // ─────────────────────────────────────────────
        // NAVIGATION BUTTONS (FIXED)
        // ─────────────────────────────────────────────

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            SetActive(btnNavProducts);
            lblPageTitle.Text = "Products";
            new AdminProductsForm().Show();
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            SetActive(btnNavOrders);
            lblPageTitle.Text = "Orders";
            new AdminOrdersForm().Show();
        }

        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            SetActive(btnNavCustomers);
            lblPageTitle.Text = "Customers";
            new AdminCustomerForm().Show();
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            SetActive(btnNavReports);
            lblPageTitle.Text = "Reports";
            new ReportsForm().Show();
        }

        // 🔥 helper (clean navigation UI)
        private void SetActive(Button btn)
        {
            _activeNav.BackColor = Color.Transparent;
            _activeNav.ForeColor = Color.FromArgb(148, 163, 184);

            btn.BackColor = Color.FromArgb(37, 99, 235);
            btn.ForeColor = Color.White;

            _activeNav = btn;
        }

        // ─────────────────────────────────────────────
        // LOGOUT
        // ─────────────────────────────────────────────
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Logout?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
            }
        }

        // ─────────────────────────────────────────────
        // CLOCK
        // ─────────────────────────────────────────────
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss   dd MMM yyyy");
        }

        // ─────────────────────────────────────────────
        // SUPER ADMIN LOGIN
        // ─────────────────────────────────────────────
        private void btnSuperAdminLogin_Click(object sender, EventArgs e)
        {
            using (var dlg = new SuperAdminLogin())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                }
            }
        }
    }
}