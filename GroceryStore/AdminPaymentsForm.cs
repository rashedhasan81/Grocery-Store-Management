using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class AdminPaymentsForm : Form
    {
        public AdminPaymentsForm()
        {
            InitializeComponent();

            btnRefresh.Click += (s, e) => LoadPayments();
            btnClose.Click += (s, e) => Close();

            // ensure table exists (will create if missing)
            EnsurePaymentsTableExists();

            LoadPayments();
        }

        private void EnsurePaymentsTableExists()
        {
            const string createSql = @"
IF OBJECT_ID('dbo.Payments','U') IS NULL
BEGIN
    CREATE TABLE dbo.Payments
    (
        PaymentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        OrderId   INT            NOT NULL,
        Method    NVARCHAR(50)   NOT NULL,
        Details   NVARCHAR(MAX)  NULL,
        Amount    DECIMAL(18,2)  NOT NULL,
        PaidAt    DATETIME       NOT NULL CONSTRAINT DF_Payments_PaidAt DEFAULT(GETDATE()),
        CreatedBy NVARCHAR(100)  NULL
    );
    ALTER TABLE dbo.Payments
    ADD CONSTRAINT FK_Payments_Orders FOREIGN KEY (OrderId) REFERENCES dbo.Orders(OrderId) ON DELETE CASCADE;
END";
            try
            {
                using var con = DatabaseHelper.GetConnection();
                con.Open();
                using var cmd = new SqlCommand(createSql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If creation fails (permissions, schema differences), show actionable message and continue
                MessageBox.Show("Could not create Payments table automatically. Run the SQL script manually.\n\n" + ex.Message,
                    "Database Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPayments()
        {
            dgvPayments.Rows.Clear();
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT
                            p.PaymentId,
                            p.OrderId,
                            o.username AS Customer,
                            u.phoneNo AS Phone,
                            p.Method,
                            p.Details,
                            p.Amount,
                            p.PaidAt
                        FROM dbo.Payments p
                        LEFT JOIN dbo.Orders o ON p.OrderId = o.OrderId
                        LEFT JOIN dbo.Users u ON o.username = u.username
                        ORDER BY p.PaidAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvPayments.Rows.Add(
                                dr["PaymentId"],
                                dr["OrderId"],
                                dr["Customer"] == DBNull.Value ? "" : dr["Customer"].ToString(),
                                dr["Method"] == DBNull.Value ? "" : dr["Method"].ToString(),
                                Convert.ToDecimal(dr["Amount"]).ToString("N2"),
                                Convert.ToDateTime(dr["PaidAt"]).ToString("yyyy-MM-dd HH:mm"),
                                dr["Details"] == DBNull.Value ? "" : dr["Details"].ToString()
                            );
                        }
                    }
                }

                dgvPayments.ClearSelection();
            }
            catch (SqlException sx)
            {
                MessageBox.Show("SQL error while loading payments:\n" + sx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load payments:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}