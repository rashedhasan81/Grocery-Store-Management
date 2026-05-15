using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();

            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            dgvOrders.CellFormatting += dgvOrders_CellFormatting;
        }

        private void LoadOrders()
        {
            dgvOrders.Rows.Clear();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            o.OrderId,
                            o.OrderDate,
                            STRING_AGG(p.ProductName, ', ') AS Products,
                            o.TotalAmount,
                            o.Status
                        FROM Orders o
                        INNER JOIN OrderItems oi ON o.OrderId = oi.OrderId
                        INNER JOIN Products p ON oi.ProductId = p.ProductId
                        WHERE o.username = @u
                        GROUP BY 
                            o.OrderId, o.OrderDate, o.TotalAmount, o.Status
                        ORDER BY o.OrderDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@u", SqlDbType.VarChar)
                                       .Value = UserSession.Username;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvOrders.Rows.Add(
                                    reader["OrderId"],
                                    "#ORD-" + reader["OrderId"].ToString(),
                                    Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd"),
                                    reader["Products"].ToString(),
                                    "৳ " + Convert.ToDecimal(reader["TotalAmount"]).ToString("N2"),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders:\n" + ex.Message);
            }
        }

        // ✅ CHECK IF USER ALREADY REVIEWED THIS ORDER
        private bool HasAlreadyReviewed(int orderId)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*) 
                    FROM dbo.Reviews 
                    WHERE OrderId = @orderId 
                    AND username = @user";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@user", UserSession.Username);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvOrders.Columns[e.ColumnIndex].Name == "colReview")
            {
                var rawIdText = dgvOrders.Rows[e.RowIndex]
                    .Cells["colOrderIdRaw"].Value?.ToString();

                if (!int.TryParse(rawIdText, out int orderId))
                {
                    MessageBox.Show("Invalid order id.");
                    return;
                }

                // ❌ RULE: Only one review per order
                if (HasAlreadyReviewed(orderId))
                {
                    MessageBox.Show(
                        "You have already reviewed this order.",
                        "Not allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                try
                {
                    using (SqlConnection con = DatabaseHelper.GetConnection())
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(
                            "SELECT Status FROM Orders WHERE OrderId = @id AND username = @u", con))
                        {
                            cmd.Parameters.AddWithValue("@id", orderId);
                            cmd.Parameters.AddWithValue("@u", UserSession.Username);

                            var status = cmd.ExecuteScalar()?.ToString();

                            if (!string.Equals(status, "Delivered", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show(
                                    "Only Delivered orders can be reviewed.",
                                    "Not allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                return;
                            }
                        }
                    }

                    // ✅ OPEN REVIEW FORM
                    var reviewForm = new CustomerReview();

                    // 🔥 FIX: pass INT (NOT string)
                    reviewForm.SetOrderId(orderId);

                    reviewForm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening review form:\n" + ex.Message);
                }
            }
        }

        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name != "colStatus") return;

            string status = e.Value?.ToString();

            if (status == "Delivered")
                e.CellStyle.ForeColor = System.Drawing.Color.Green;
            else if (status == "Processing")
                e.CellStyle.ForeColor = System.Drawing.Color.Orange;
            else if (status == "Shipped")
                e.CellStyle.ForeColor = System.Drawing.Color.Blue;
            else if (status == "Cancelled")
                e.CellStyle.ForeColor = System.Drawing.Color.Red;
            else
                e.CellStyle.ForeColor = System.Drawing.Color.Black;
        }
    }
}