using System;
using System.Windows.Forms;

namespace GroceryStore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Run once to seed a super-admin; remove this line after success
           // GroceryStore.Utils.SeedSuperAdminRunner.Run("superadmin", "StrongP@ssw0rd!");

            Application.Run(new Login());
            Application.Run(new SuperAdminLogin());
        }
    }
}