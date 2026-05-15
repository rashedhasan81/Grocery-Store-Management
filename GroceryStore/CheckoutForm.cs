using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();

            rbBkash.CheckedChanged += PaymentOptionChanged;
            rbNagad.CheckedChanged += PaymentOptionChanged;
            rbCard.CheckedChanged += PaymentOptionChanged;
            btnPay.Click += btnPay_Click;
            btnCancel.Click += btnCancel_Click;

            LoadCartItems();
        }

        private void PaymentOptionChanged(object? sender, EventArgs e)
        {
            pnlMobile.Visible = rbBkash.Checked || rbNagad.Checked;
            pnlCard.Visible = rbCard.Checked;
        }

        private void LoadCartItems()
        {
            dgvCheckoutItems.Rows.Clear();

            decimal total = 0m;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT p.ProductId, p.ProductName, p.Price, c.Quantity
                        FROM Cart c
                        INNER JOIN Products p ON c.ProductId = p.ProductId
                        WHERE c.username = @u";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pid = reader["ProductId"].ToString();
                                var name = reader["ProductName"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                int qty = Convert.ToInt32(reader["Quantity"]);
                                decimal subtotal = price * qty;
                                total += subtotal;

                                dgvCheckoutItems.Rows.Add(pid, name, price.ToString("F2"), qty.ToString(), subtotal.ToString("F2"));
                            }
                        }
                    }
                }

                lblTotal.Text = "৳ " + total.ToString("F2");
                dgvCheckoutItems.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load cart:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object? sender, EventArgs e)
        {
            if (dgvCheckoutItems.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // simple payment validation
            if (!(rbBkash.Checked || rbNagad.Checked || rbCard.Checked))
            {
                MessageBox.Show("Choose a payment method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((rbBkash.Checked || rbNagad.Checked))
            {
                if (string.IsNullOrWhiteSpace(txtMobile.Text) || string.IsNullOrWhiteSpace(txtTxnId.Text))
                {
                    MessageBox.Show("Enter phone and transaction ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rbCard.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCardName.Text) ||
                    string.IsNullOrWhiteSpace(txtExpiry.Text) ||
                    string.IsNullOrWhiteSpace(txtCvv.Text))
                {
                    MessageBox.Show("Enter complete card details.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal total = 0m;
            foreach (DataGridViewRow r in dgvCheckoutItems.Rows)
            {
                if (r.IsNewRow) continue;
                if (!decimal.TryParse(r.Cells["colSubtotal"].Value?.ToString(), out var sub)) sub = 0m;
                total += sub;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();
                    using (SqlTransaction tx = con.BeginTransaction())
                    {
                        try
                        {
                            // Insert order
                            string insertOrder = @"
                                INSERT INTO Orders (username, OrderDate, TotalAmount, Status)
                                VALUES (@u, GETDATE(), @total, @status);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                            int orderId;
                            using (SqlCommand cmd = new SqlCommand(insertOrder, con, tx))
                            {
                                cmd.Parameters.AddWithValue("@u", UserSession.Username);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@status", "Processing");
                                orderId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // Insert order items
                            string insertItem = @"
                                INSERT INTO OrderItems (OrderId, ProductId, Quantity)
                                VALUES (@o, @p, @q)";

                            foreach (DataGridViewRow r in dgvCheckoutItems.Rows)
                            {
                                if (r.IsNewRow) continue;
                                string pid = r.Cells["colProductId"].Value.ToString();
                                int qty = Convert.ToInt32(r.Cells["colQty"].Value);

                                using (SqlCommand cmd = new SqlCommand(insertItem, con, tx))
                                {
                                    cmd.Parameters.AddWithValue("@o", orderId);
                                    cmd.Parameters.AddWithValue("@p", pid);
                                    cmd.Parameters.AddWithValue("@q", qty);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Optionally store payment record (simple)
                            string insertPayment = @"
                                INSERT INTO Payments (OrderId, Method, Details, Amount, PaidAt)
                                VALUES (@o, @m, @d, @a, GETDATE())";
                            // Payments table may not exist in schema; wrap in try/catch so missing table won't abort order
                            try
                            {
                                using (SqlCommand pcmd = new SqlCommand(insertPayment, con, tx))
                                {
                                    pcmd.Parameters.AddWithValue("@o", orderId);
                                    string method = rbBkash.Checked ? "bKash" : rbNagad.Checked ? "Nagad" : "Card";
                                    pcmd.Parameters.AddWithValue("@m", method);
                                    string details = method == "Card"
                                        ? $"Card:{txtCardNumber.Text};Name:{txtCardName.Text};Exp:{txtExpiry.Text}"
                                        : $"Phone:{txtMobile.Text};Txn:{txtTxnId.Text}";
                                    pcmd.Parameters.AddWithValue("@d", details);
                                    pcmd.Parameters.AddWithValue("@a", total);
                                    pcmd.ExecuteNonQuery();
                                }
                            }
                            catch
                            {
                                // ignore if Payments table doesn't exist
                            }

                            // Clear cart
                            string delCart = "DELETE FROM Cart WHERE username=@u";
                            using (SqlCommand del = new SqlCommand(delCart, con, tx))
                            {
                                del.Parameters.AddWithValue("@u", UserSession.Username);
                                del.ExecuteNonQuery();
                            }

                            tx.Commit();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    } // tx
                } // conn

                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}