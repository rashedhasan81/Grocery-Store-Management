using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            btnRefresh.Click += (s, e) => LoadReviews();
            btnClose.Click += (s, e) => Close();

            LoadReviews();
        }

        private void LoadReviews()
        {
            dgvReviews.Rows.Clear();
            lblStats.Text = "Avg: —   Count: 0";

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            r.ReviewId,
                            r.OrderId,
                            r.username,
                            r.Rating,
                            r.Comment,
                            r.CreatedAt
                        FROM dbo.Reviews r
                        ORDER BY r.CreatedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        int count = 0;
                        decimal sum = 0m;

                        while (dr.Read())
                        {
                            int reviewId = Convert.ToInt32(dr["ReviewId"]);
                            int orderId = Convert.ToInt32(dr["OrderId"]);
                            string user = dr["username"]?.ToString() ?? "";
                            int rating = dr["Rating"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"]);
                            string comment = dr["Comment"]?.ToString() ?? "";
                            string date = dr["CreatedAt"] == DBNull.Value
                                ? ""
                                : Convert.ToDateTime(dr["CreatedAt"]).ToString("yyyy-MM-dd HH:mm");

                            dgvReviews.Rows.Add(
                                reviewId,
                                "#ORD-" + orderId,
                                user,
                                rating,
                                comment,
                                date
                            );

                            if (rating > 0)
                            {
                                sum += rating;
                                count++;
                            }
                        }

                        if (count > 0)
                        {
                            lblStats.Text = $"Avg: {sum / count:F1}   Count: {count}";
                        }
                        else
                        {
                            lblStats.Text = "Avg: —   Count: 0";
                        }
                    }
                }

                dgvReviews.ClearSelection();
            }
            catch (SqlException sx)
            {
                MessageBox.Show("Database error loading reviews:\n" + sx.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reviews:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}