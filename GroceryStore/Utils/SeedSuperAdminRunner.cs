using System;
using System.Windows.Forms;

namespace GroceryStore.Utils
{
    internal static class SeedSuperAdminRunner
    {
        /// <summary>
        /// Run this once to insert a SuperAdmin row.
        /// Call from Immediate Window or temporarily from Program.Main:
        /// SeedSuperAdminRunner.Run("superadmin", "YourStrongPassword!");
        /// Then remove / comment out the call.
        /// </summary>
        public static void Run(string username, string password)
        {
            try
            {
                SuperAdminSeeder.Seed(username, password);
                MessageBox.Show($"Super admin '{username}' seeded successfully.", "Seed Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seeding error:\n" + ex.Message, "Seed Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// To run the seeder, call the following from your Program.Main or Immediate Window:
// GroceryStore.Utils.SeedSuperAdminRunner.Run("superadmin", "StrongP@ssw0rd!");