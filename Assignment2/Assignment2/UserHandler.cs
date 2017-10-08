using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class UserHandler
    {
        enum AdminType { SuperAdmin, Moderator };

        private List<User> users;
        private User loggedInUser;
        public User LoggedInUser
        {
            get
            {
                return loggedInUser;
            }
            set
            {
                loggedInUser = value;
            }
        }

        
        //user1,password123,John,Smith,12-09-1973,7,4.2
        private System.DateTime dateToDate(string date)
        {
            string[] tmp = date.Split('-');

            return new System.DateTime(Convert.ToInt32(tmp[2]), Convert.ToInt32(tmp[1]), Convert.ToInt32(tmp[0]));
        }

        private Type toType(string type)
        {
            if (type == "SuperAdmin") return UserHandler.AdminType.SuperAdmin.GetType();
            else
            {
                return UserHandler.AdminType.Moderator.GetType();
            }
        }


// Load all user data from “Guests.txt” and “Admins.txt” plain text files and stores them in the User  List member variable.

        public bool LoadAllUsers()
        {
            string tmp;
            System.IO.StreamReader sr = new System.IO.StreamReader("Guests.txt");

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine();
                string[] info = tmp.Split(',');
                users.Add(new Guest(info[0], info[1], info[2], info[3], Convert.ToInt32(info[5]), Convert.ToInt32(info[6]), dateToDate(info[4])));
            }

            sr = new System.IO.StreamReader("Admin.txt");

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine();
                string[] info = tmp.Split(',');
                //topAdmin,ImTheBest,Tony,Stark,SuperAdmin,10,1.25
                users.Add(new Admin(info[0], info[1], info[2], info[3], Convert.ToInt32(info[5]), Convert.ToInt32(info[6]), toType(info[4])));
            }


            return true;
        }

// Save all user data from “Guests.txt” and “Admins.txt”  plain txt  files  using  the  WriteGuestToFile(...)  and WriteAdminToFile(...) methods below
        public bool SaveAllUsers()
        {
            return true;
        }
    }
}
