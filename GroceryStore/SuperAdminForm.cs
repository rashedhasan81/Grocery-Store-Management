using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class SuperAdminForm : Form
    {
        private int selectedId = -1;

        public SuperAdminForm()
        {
            InitializeComponent();
            LoadAdmins();
        }

        // LOAD DATA
        private void LoadAdmins()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Admins";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAdmins.DataSource = dt;
            }
        }

        // CLEAR
        private void ClearFields()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            chkIsActive.Checked = false;
            selectedId = -1;
        }

        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Admins 
                                (Name, Username, Password, IsActive)
                                VALUES (@Name, @Username, @Password, @IsActive)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAdmins();
            ClearFields();
        }

        // SELECT ROW
        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmins.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Admins 
                                 SET Name=@Name,
                                     Username=@Username,
                                     Password=@Password,
                                     IsActive=@IsActive
                                 WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", selectedId);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAdmins();
            ClearFields();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Admins WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", selectedId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAdmins();
            ClearFields();
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}