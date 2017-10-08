using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class UserHandler
    {
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


        // not implemented
        private System.DateTime dateToDate(string date)
        {
            return new System.DateTime(0);
        }


// Load all user data from “Guests.txt” and “Admins.txt” plain text files and stores them in the User  List member variable.

        public bool LoadAllUsers()
        {
            string tmp;
            System.IO.StreamReader sr = new System.IO.StreamReader("Guests.txt");

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine();
                string[] info = tmp.Split(new char[]{','});
                users.Add(new Guest(info[0], info[1], info[2], info[3], Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), dateToDate(info[6])));
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
