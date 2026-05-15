using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class AdminProductsForm : Form
    {
        int selectedId = -1;
        bool isReloading = false;   // 🔥 IMPORTANT FIX FLAG

        public AdminProductsForm()
        {
            InitializeComponent();

            LoadProducts();

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            dgvProducts.CellClick += DgvProducts_CellClick;
        }

        // ================= LOAD =================
        private void LoadProducts()
        {
            isReloading = true;   // 🔥 BLOCK EVENTS

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Products ORDER BY ProductId DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.DataSource = dt;
            }

            dgvProducts.ClearSelection();
            selectedId = -1;

            isReloading = false;  // 🔥 UNBLOCK EVENTS
        }

        // ================= ADD =================
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // 🔥 PREVENT DUPLICATE PRODUCT
                string checkQuery = "SELECT COUNT(*) FROM Products WHERE ProductName=@name";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@name", txtName.Text);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Product already exists!");
                    return;
                }

                string query = @"
                    INSERT INTO Products (ProductName, Price, Stock, Category)
                    VALUES (@name, @price, @stock, @cat)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@cat", "General");

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Added!");

            ClearFields();
            LoadProducts();
        }

        // ================= SELECT =================
        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isReloading) return;   // 🔥 FIX DOUBLE EVENT BUG
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            if (row.Cells["ProductId"].Value == null) return;

            selectedId = Convert.ToInt32(row.Cells["ProductId"].Value);

            txtName.Text = row.Cells["ProductName"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtStock.Text = row.Cells["Stock"].Value.ToString();
        }

        // ================= UPDATE =================
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Select product first!");
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Products
                    SET ProductName=@name,
                        Price=@price,
                        Stock=@stock
                    WHERE ProductId=@id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Updated!");

            ClearFields();
            LoadProducts();
        }

        // ================= DELETE =================
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Select product first!");
                return;
            }

            DialogResult res = MessageBox.Show(
                "Delete this product?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (res != DialogResult.Yes) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM Products WHERE ProductId=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Deleted!");

            ClearFields();
            LoadProducts();
        }

        // ================= SEARCH =================
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT * FROM Products
                    WHERE ProductName LIKE @search
                    ORDER BY ProductId DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.DataSource = dt;
            }

            dgvProducts.ClearSelection();
            selectedId = -1;
        }

        // ================= CLEAR =================
        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            selectedId = -1;
        }
    }
}