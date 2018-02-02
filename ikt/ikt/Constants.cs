using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt
{
    public class Constants
    {
        public static int UserNameLength { get; } = 5;

        public static bool CheckIfValidUser(string userEmail)
        {
            string userName = userEmail.Split('@')[0];
            if (userName.Length == UserNameLength || Developers.Contains(userName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string[] Developers { get; } =
        {
            "9810pema",
            "9824leda",
            "9709ekch"
        };
    }
}