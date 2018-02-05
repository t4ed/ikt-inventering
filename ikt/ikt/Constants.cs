using ikt.DAL;
using ikt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt
{
    public class Constants
    {
        private static iktContext db = new iktContext();

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

        public static Staff GetStaffInfo(string userEmail)
        {
            string username = userEmail.Split('@')[0];

            var staffdata = from Staff in db.Staff
                        where Staff.Username == username
                        select Staff;

            

            if (staffdata.Count() == 1)
            {
                Staff staff = new Staff();

                foreach (var data in staffdata)
                {
                    staff.ID = data.ID;
                    staff.Username = data.Username;
                    staff.FirstName = data.FirstName;
                    staff.LastName = data.LastName;
                }

                return staff;
            }
            else
            {
                return new Staff()
                {
                    Username = "Wrong",
                    FirstName = "fname",
                    LastName = "lname"
                };
            }
        }

        public static string[] Developers { get; } =
        {
            "9810pema",
            "9824leda",
            "9709ekch",
            "9628hujo",
            "9801riji",
            "9827skma",
            "9825faed"
        };
    }
}