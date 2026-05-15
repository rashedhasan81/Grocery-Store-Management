using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class CustomerReview : Form
    {
        private int _orderId;

        public CustomerReview()
        {
            InitializeComponent();

            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        // ✅ FIX: MUST BE INT (NOT STRING)
        public void SetOrderId(int orderId)
        {
            _orderId = orderId;

            if (txtOrderId != null)
                txtOrderId.Text = orderId.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserSession.Username == null)
                {
                    MessageBox.Show("User not logged in.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtComment.Text))
                {
                    MessageBox.Show("Please enter a comment.");
                    return;
                }

                using SqlConnection con = DatabaseHelper.GetConnection();
                con.Open();

                // 1️⃣ CHECK ORDER STATUS
                string statusQuery = @"
                    SELECT Status 
                    FROM Orders 
                    WHERE OrderId = @oid AND username = @u";

                using (SqlCommand cmd = new SqlCommand(statusQuery, con))
                {
                    cmd.Parameters.AddWithValue("@oid", _orderId);
                    cmd.Parameters.AddWithValue("@u", UserSession.Username);

                    var statusObj = cmd.ExecuteScalar();

                    if (statusObj == null)
                    {
                        MessageBox.Show("Order not found.");
                        return;
                    }

                    string status = statusObj.ToString();

                    if (!status.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Only Delivered orders can be reviewed.");
                        return;
                    }
                }

                // 2️⃣ CHECK DUPLICATE REVIEW
                string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM dbo.Reviews 
                    WHERE OrderId = @oid AND username = @u";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@oid", _orderId);
                    checkCmd.Parameters.AddWithValue("@u", UserSession.Username);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("You already reviewed this order.");
                        return;
                    }
                }

                // 3️⃣ INSERT REVIEW
                string insertSql = @"
                    INSERT INTO dbo.Reviews (OrderId, username, Rating, Comment)
                    VALUES (@oid, @u, @r, @c)";

                using (SqlCommand ins = new SqlCommand(insertSql, con))
                {
                    ins.Parameters.AddWithValue("@oid", _orderId);
                    ins.Parameters.AddWithValue("@u", UserSession.Username);
                    ins.Parameters.AddWithValue("@r", (int)numRating.Value);
                    ins.Parameters.AddWithValue("@c", txtComment.Text.Trim());

                    ins.ExecuteNonQuery();
                }

                MessageBox.Show("Review submitted successfully!");
                this.Close();
            }
            catch (SqlException sx)
            {
                MessageBox.Show("Database error:\n" + sx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
    }
}