using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    public static class UserSession
    {
        private static string _username;

        public static string Username
        {
            get => _username;
            set => _username = string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(_username);

        public static void Clear()
        {
            _username = null;
        }
    }
}
