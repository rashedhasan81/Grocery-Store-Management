using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            SetupGrid();
            LoadProducts();

            btnAddToCart.Click += btnAddToCart_Click;
            btnSearch.Click += btnSearch_Click;
        }

        // ================= GRID =================
        private void SetupGrid()
        {
            dgvProducts.Columns.Clear();

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.Columns.Add("colId", "ID");
            dgvProducts.Columns.Add("colName", "Product Name");
            dgvProducts.Columns.Add("colPrice", "Price");
            dgvProducts.Columns.Add("colStock", "Stock");

            dgvProducts.Columns["colName"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        // ================= LOAD PRODUCTS =================
        private void LoadProducts(string keyword = "")
        {
            dgvProducts.Rows.Clear();

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query =
                        @"SELECT ProductId,
                                 ProductName,
                                 Price,
                                 Stock
                          FROM Products
                          WHERE ProductName LIKE @search
                          ORDER BY ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@search",
                            "%" + keyword + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvProducts.Rows.Add(
                                    reader["ProductId"].ToString(),
                                    reader["ProductName"].ToString(),
                                    reader["Price"].ToString(),
                                    reader["Stock"].ToString()
                                );
                            }
                        }
                    }
                }

                // Clear any default selection so user must explicitly select a row
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Product load failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ================= SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        // ================= ADD TO CART =================
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Require an explicit selection (SelectedRows) rather than relying on CurrentRow
            if (dgvProducts.SelectedRows == null || dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            var row = dgvProducts.SelectedRows[0];

            string productId = row.Cells["colId"].Value?.ToString() ?? "";
            string productName = row.Cells["colName"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Selected row is invalid.");
                return;
            }

            if (!int.TryParse(row.Cells["colStock"].Value?.ToString(), out int stock))
            {
                MessageBox.Show("Invalid stock value.");
                return;
            }

            int qty = (int)nudQuantity.Value;

            if (qty < 1)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    // get current quantity in cart (if any)
                    string selectQuery =
                        @"SELECT Quantity FROM Cart WHERE username=@u AND ProductId=@p";

                    int existingQty = 0;
                    using (SqlCommand selCmd = new SqlCommand(selectQuery, con))
                    {
                        selCmd.Parameters.AddWithValue("@u", UserSession.Username);
                        selCmd.Parameters.AddWithValue("@p", productId);
                        object obj = selCmd.ExecuteScalar();
                        existingQty = (obj == null || obj == DBNull.Value) ? 0 : Convert.ToInt32(obj);
                    }

                    // ensure we don't exceed stock
                    if (existingQty + qty > stock)
                    {
                        MessageBox.Show($"Cannot add {qty} item(s). Only {stock - existingQty} available.");
                        return;
                    }

                    if (existingQty > 0)
                    {
                        string updateQuery =
                            @"UPDATE Cart
                              SET Quantity = Quantity + @q
                              WHERE username=@u
                              AND ProductId=@p";

                        using (SqlCommand updateCmd =
                            new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@u", UserSession.Username);
                            updateCmd.Parameters.AddWithValue("@p", productId);
                            updateCmd.Parameters.AddWithValue("@q", qty);

                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery =
                            @"INSERT INTO Cart
                              (username, ProductId, Quantity)
                              VALUES
                              (@u, @p, @q)";

                        using (SqlCommand insertCmd =
                            new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@u", UserSession.Username);
                            insertCmd.Parameters.AddWithValue("@p", productId);
                            insertCmd.Parameters.AddWithValue("@q", qty);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show(
                    $"{productName} (x{qty}) added to cart!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // After adding, clear selection so accidental double-clicks won't re-add
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Add to cart failed:\n" + ex.Message);
            }
        }
    }
}