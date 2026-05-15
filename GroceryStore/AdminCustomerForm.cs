using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class AdminCustomerForm : Form
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private DataTable dt = new DataTable();
        private string selectedUser = "";

        public AdminCustomerForm()
        {
            InitializeComponent();
            LoadData();
        }

        // LOAD DATA
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT username, mail, phoneNo FROM Users";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                dgvCustomers.DataSource = dt;
            }
        }

        // SELECT ROW
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            selectedUser = dgvCustomers.CurrentRow.Cells["username"].Value.ToString();
        }

        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();

            DataView dv = dt.DefaultView;
            dv.RowFilter =
                $"username LIKE '%{key}%' OR phoneNo LIKE '%{key}%' OR mail LIKE '%{key}%'";
        }

        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string u = Prompt("Username:");
            string p = Prompt("Phone:");
            string m = Prompt("Email:");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users(username, phoneNo, mail, password) VALUES(@u,@p,@m,'1234')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", u);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@m", m);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Select a customer first");
                return;
            }

            string p = Prompt("New Phone:");
            string m = Prompt("New Email:");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET phoneNo=@p, mail=@m WHERE username=@u";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@m", m);
                cmd.Parameters.AddWithValue("@u", selectedUser);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Select a customer first");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE username=@u";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", selectedUser);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        // INPUT BOX
        private string Prompt(string text)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(text, "Input", "");
        }
    }
}