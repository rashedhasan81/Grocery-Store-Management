using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class AdminOrdersForm : Form
    {
        private DataTable ordersTable;
        private int selectedOrderId = -1;

        public AdminOrdersForm()
        {
            InitializeComponent();

            LoadOrders();

            dgvOrders.CellClick += dgvOrders_CellClick;

            btnAccept.Click += (s, e) => UpdateStatus("Processing");
            btnShip.Click += (s, e) => UpdateStatus("Shipped");
            btnDeliver.Click += (s, e) => UpdateStatus("Delivered");
            btnCancel.Click += (s, e) => UpdateStatus("Cancelled");
            btnPayments.Click += btnPayments_Click;
        }

        // ================= LOAD ORDERS =================
        private void LoadOrders()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        o.OrderId,
                        o.username AS Customer,
                        u.phoneNo AS Phone,
                        o.TotalAmount,
                        o.OrderDate,
                        o.Status
                    FROM Orders o
                    INNER JOIN Users u ON o.username = u.username
                    ORDER BY o.OrderId DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                ordersTable = new DataTable();
                da.Fill(ordersTable);

                dgvOrders.DataSource = ordersTable;
            }

            selectedOrderId = -1;
            dgvOrders.ClearSelection();
        }

        // ================= SELECT ORDER =================
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedOrderId = Convert.ToInt32(
                dgvOrders.Rows[e.RowIndex].Cells["OrderId"].Value
            );
        }

        // ================= UPDATE STATUS =================
        private void UpdateStatus(string status)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Select an order first!");
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "UPDATE Orders SET Status = @status WHERE OrderId = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", selectedOrderId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order updated: " + status);

            LoadOrders();
        }

        // ================= PAYMENTS VIEW =================
        private void btnPayments_Click(object sender, EventArgs e)
        {
            // If you want to show all payments:
            new AdminPaymentsForm().ShowDialog(this);
            // Optionally reload orders/payments after closing
            LoadOrders();
        }
    }
}