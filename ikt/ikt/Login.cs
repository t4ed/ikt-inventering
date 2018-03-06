using ikt.DAL;
using ikt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ikt
{
    public class Login
    {
        private static iktContext db = new iktContext();

        public static bool CheckIfValidUser(string userEmail)
        {
            string userName = userEmail.Split('@')[0];
            if ((userName.Length == Constants.UserNameLength || Constants.Developers.Contains(userName)) && !Constants.BlackList.Contains(userName))
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
            Staff staff = new Staff();

            string username = userEmail.Split('@')[0];

            if ((string)HttpContext.Current.Session["Username"] == username)
            {
                staff = GetStaffFromCookie(username);
            }
            else
            {
                staff = GetStaffFromDb(username);
                SetStaffCookie(staff);
            }
            return staff;
        }

        private static Staff GetStaffFromCookie(string username)
        {
            Staff staff = new Staff()
            {
                Username = (string)HttpContext.Current.Session["Username"],
                FirstName = (string)HttpContext.Current.Session["FirstName"],
                LastName = (string)HttpContext.Current.Session["LastName"]
            };
            return staff;
        }

        private static Staff GetStaffFromDb(string username)
        {
            Staff staff = new Staff();
            var staffdata = from Staff in db.Staff
                            where Staff.Username == username
                            select Staff;

            if (staffdata.Count() == 1)
            {
                foreach (var data in staffdata)
                {
                    staff.Username = data.Username;
                    staff.FirstName = data.FirstName;
                    staff.LastName = data.LastName;
                }
            }
            else if (staffdata.Count() > 1)
            {
                throw new OperationCanceledException("Expected one result, got multiple.");
            }
            else
            {
                staff = new Staff()
                {
                    Username = "invalid",
                    FirstName = "",
                    LastName = ""
                };
            }
            return staff;
        }

        private static void SetStaffCookie(Staff staff)
        {
            HttpContext.Current.Session["Username"] = staff.Username;
            HttpContext.Current.Session["FirstName"] = staff.FirstName;
            HttpContext.Current.Session["LastName"] = staff.LastName;
        }
    }
}