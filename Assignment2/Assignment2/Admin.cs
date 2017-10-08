using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Admin : User
    {
        enum AdminType { SuperAdmin, Moderator};

        private AdminType adminType;

        public Admin(string username, string password, string firstName, string lastName, int ratingsCount, float averageRatingAdmin, Type AdminType)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRatingAdmin;

            //not sure of line below
            if (Type.Equals(adminType.GetType(), AdminType)) adminType = Admin.AdminType.SuperAdmin;

        }
// writes all member variable of this Admin object (including those in the        User  base  class)  to the  end of  the file  passed  in  as a parameter  and returns true if the write was successful
        public bool WriteAdminToFile(System.IO.StreamWriter file)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(username + ", ");
            sb.Append(password + ", ");
            sb.Append(firstName + ", ");
            sb.Append(lastName + ", ");
            sb.Append(ratingsCount + ", ");
            sb.Append(averageRating);

            file.WriteLine(sb.ToString());

            // "returns true if the write was successful."
            //successful writing??
            return true;
        }

// overrides  base  class version, returns a string with username, firstName, lastName, and AdminType
        public override string GetFullUserString()
        {
            return (username + firstName + lastName + adminType);
        }
    }
}
