using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            // ✅ Input validation
            if (string.IsNullOrWhiteSpace(usertxt.Text) ||
                string.IsNullOrWhiteSpace(mailtxt.Text) ||
                string.IsNullOrWhiteSpace(phntxt.Text) ||
                string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (passtxt.Text != confirmpasstxt.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.",
                                "Password Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // ✅ Terms checkbox
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions.",
                                "Terms Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=groceryshop_signUp;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // ✅ Check if username exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usertxt.Text;

                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Try another.");
                        return;
                    }
                }

                // ✅ Insert new user
                string insertQuery = @"INSERT INTO Users (username, mail, phoneNo, password)
                               VALUES (@username, @mail, @phoneNo, @password)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usertxt.Text;
                    cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mailtxt.Text;
                    cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = phntxt.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passtxt.Text;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Signup successful!");
                this.Hide();
                new Login().Show();
            }
        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgg = new Login();
            lgg.Show();
        }
    }
}