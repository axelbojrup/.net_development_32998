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

        public UserHandler()
        {
            users = new List<User>();
        }

        
        //user1,password123,John,Smith,12-09-1973,7,4.2
        private System.DateTime dateToDate(string date)
        {
            int day, month, year;
            string[] tmp = date.Split('-');

            if (!int.TryParse(tmp[0], out day)) Console.WriteLine("Conversion failed: day");
            if (!int.TryParse(tmp[1], out month)) Console.WriteLine("Conversion failed: month");
            if (!int.TryParse(tmp[2], out year)) Console.WriteLine("Conversion failed: year");

            return new System.DateTime(year, month, day);
        }

        private Type toType(string type)
        {
            if (type.Equals("SuperAdmin")) return Admin.AdminType.SuperAdmin.GetType();
            else
            {
                return Admin.AdminType.Moderator.GetType();
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
                try
                {
                    int ratingsCount;
                    double averageRating;
                    //user1,password123,John,Smith,12-09-1973,7,4.2
                    string username = info[0];
                    string password = info[1];
                    string firstName = info[2];
                    string lastName = info[3];
                    string date = info[4];

                    if (!int.TryParse(info[5], out ratingsCount)) Console.WriteLine("Conversion failed: ratingsCount");
                    if (!double.TryParse(info[6], out averageRating)) Console.WriteLine("Conversion failed: averageRating");

                    DateTime tmp2 = dateToDate(date);
                    User guest = new Guest(username, password, firstName, lastName, ratingsCount, (float)averageRating, tmp2);
                    users.Add(guest);
                }
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
                
               
            }

            sr = new System.IO.StreamReader("Admin.txt");

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine();
                string[] info = tmp.Split(',');
                try
                {
                    int ratingsCount;
                    double averageRating;
                    //topAdmin,ImTheBest,Tony,Stark,SuperAdmin,10,1.25
                    string username = info[0];
                    string password = info[1];
                    string firstName = info[2];
                    string lastName = info[3];

                    Type AdminType = toType(info[4]);

                    if (!int.TryParse(info[5], out ratingsCount)) Console.WriteLine("Conversion failed: ratingsCount");
                    if (!double.TryParse(info[6], out averageRating)) Console.WriteLine("Conversion failed: averageRating");

                    Admin admin = new Admin(username, password, firstName, lastName, ratingsCount, (float)averageRating, AdminType);

                    users.Add(admin);
                }
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
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
