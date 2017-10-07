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


// Load all user data from “Guests.txt” and “Admins.txt” plain text files and stores them in the User  List member variable.

        public bool LoadAllUsers()
        {
            return true;
        }
        Save all user data from “Guests.txt” and 
// “Admins.txt”  plain txt  files  using  the  WriteGuestToFile(...)  and WriteAdminToFile(...) methods below
        public bool SaveAllUsers()
        {

        }
    }
}
