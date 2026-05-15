using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class CartForm : Form
    {
        private string username;

        public CartForm()
        {
            InitializeComponent();

            username = UserSession.Username;

            btnCheckout.Click += btnCheckout_Click;
            btnRemove.Click += btnRemove_Click;

            LoadCart();
        }

        // ================= LOAD CART =================
        private void LoadCart()
        {
            dgvCart.Rows.Clear();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query =
                        @"SELECT
                            p.ProductName,
                            c.Quantity,
                            p.Price,
                            (c.Quantity * p.Price) AS Subtotal
                          FROM Cart c
                          INNER JOIN Products p ON c.ProductId = p.ProductId
                          WHERE c.username = @u
                          ORDER BY p.ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvCart.Rows.Add(
                                    reader["ProductName"].ToString(),
                                    reader["Quantity"].ToString(),
                                    reader["Price"].ToString(),
                                    reader["Subtotal"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load cart:\n" + ex.Message);
            }

            UpdateTotal();
        }

        // ================= TOTAL =================
        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["colSubtotal"].Value?.ToString(), out decimal sub))
                    total += sub;
            }

            lblTotal.Text = "Total:  ৳ " + total.ToString("N2");
        }

        // ================= REMOVE ITEM =================
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select an item first.");
                return;
            }

            string product = dgvCart.CurrentRow.Cells["colProduct"].Value?.ToString();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query =
                        @"DELETE FROM Cart
                          WHERE username=@u
                          AND ProductId = (
                              SELECT ProductId FROM Products WHERE ProductName=@p)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", product);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove failed:\n" + ex.Message);
            }
        }

        // ================= CHECKOUT =================
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            // Open the CheckoutForm so it handles order creation and payment UI
            using (var checkout = new CheckoutForm())
            {
                // Show as modal so user completes or cancels checkout before returning
                checkout.ShowDialog(this);
            }

            // Refresh cart after returning (CheckoutForm clears the cart on success)
            LoadCart();
        }
    }
}