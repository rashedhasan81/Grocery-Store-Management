using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class SuperAdminLogin : Form
    {
        // Hardcoded credentials
        private const string USERNAME = "superadmin";

        // Hashed password (computed from "superadmin")
        private static readonly string PASSWORD_HASH = ComputeHash("superadmin");

        public SuperAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password.");
                return;
            }

            // Validate login
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");

                // 🔴 Close AdminDashboard if it's already open
                var adminForm = Application.OpenForms
                                           .OfType<AdminDashboard>()
                                           .FirstOrDefault();

                if (adminForm != null)
                {
                    adminForm.Close();
                }

                // ✅ Open SuperAdmin panel
                SuperAdminForm superAdminForm = new SuperAdminForm();
                superAdminForm.Show();

                // ✅ Hide current login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid super admin credentials.");
            }
        }

        private static bool ValidateLogin(string username, string password)
        {
            if (username != USERNAME)
                return false;

            string inputHash = ComputeHash(password);
            return inputHash == PASSWORD_HASH;
        }

        private static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}