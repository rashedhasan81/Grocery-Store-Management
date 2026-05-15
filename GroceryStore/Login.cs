using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Signup ssign = new Signup();
            this.Hide();
            ssign.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // ✅ Check empty fields
            if (string.IsNullOrWhiteSpace(userbox.Text) ||
                string.IsNullOrWhiteSpace(passbox.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // =========================
            // 🔐 ADMIN LOGIN (DATABASE)
            // =========================
            if (checkBox1.Checked)
            {
                try
                {
                    using (SqlConnection con = DatabaseHelper.GetConnection())
                    {
                        string query = @"SELECT COUNT(*) 
                                         FROM Admins 
                                         WHERE Username = @username 
                                         AND Password = @password 
                                         AND IsActive = 1";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = userbox.Text;
                            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passbox.Text;

                            con.Open();
                            int result = (int)cmd.ExecuteScalar();
                            con.Close();

                            if (result > 0)
                            {
                                MessageBox.Show("Admin login successful!");

                                AdminDashboard adminForm = new AdminDashboard();
                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid admin credentials or inactive account.",
                                    "Admin Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                return; // stop here (do NOT go to user login)
            }

            // =========================
            // 👤 USER LOGIN (DATABASE)
            // =========================

            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=groceryshop_signUp;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) 
                                 FROM Users 
                                 WHERE username=@username 
                                 AND password=@password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = userbox.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passbox.Text;

                    try
                    {
                        con.Open();
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");

                            UserSession.Username = userbox.Text;

                            CustomerDashboard customerForm = new CustomerDashboard();
                            customerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}