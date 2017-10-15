using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Guest : User
    {
        private DateTime dateOfBirth;

        public Guest(string username, string password, string firstName, string lastName, int ratingsCount, double averageRating, DateTime dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.averageRating = roundDown(averageRating);
            this.ratingsCount = ratingsCount;
            this.dateOfBirth = dateOfBirth;
        }

        private string getDate()
        {
            return dateOfBirth.ToString("dd-MM-yyyy");
        }

        public Admin makeAdmin()
        {
            return new Admin(username, password, firstName, lastName, ratingsCount, averageRating, Admin.AdminType.Moderator);
        }

        // writes all member variable of this Guest object (including those in the User  base  class) to the  end of  the file  passed  in  as  a parameter  and returns true if the write was successful.
        public bool WriteGuestToFile(System.IO.StreamWriter file)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(username + ",");
            sb.Append(password + ",");
            sb.Append(firstName + ",");
            sb.Append(lastName + ",");
            sb.Append(getDate() + ",");
            sb.Append(ratingsCount + ",");
            sb.Append(averageRating + "\n");
            

            file.Write(sb.ToString());

            // "returns true if the write was successful."
            //successful writing??
            return true;
        }

// overrides  base  class  version, returns a string with firstName, lastName, and dateOfBirth.
        public override string GetFullUserString()
        {
            return firstName + " " + lastName + " " + getDate();
        }
    }
}
