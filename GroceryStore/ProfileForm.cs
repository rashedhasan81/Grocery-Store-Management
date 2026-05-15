using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class ProfileForm : Form
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=groceryshop_signUp;Integrated Security=True";

        public ProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            if (string.IsNullOrWhiteSpace(UserSession.Username))
            {
                MessageBox.Show("User not logged in!");
                this.Close();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT username, mail, phoneNo FROM Users WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", UserSession.Username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["username"].ToString();
                            txtEmail.Text = reader["mail"].ToString();
                            txtPhone.Text = reader["phoneNo"].ToString();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = @"UPDATE Users 
                                       SET mail = @mail,
                                           phoneNo = @phone
                                       WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@username", UserSession.Username);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile Updated Successfully!");
            }
        }
    }
}