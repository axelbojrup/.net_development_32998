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
            // this.adminType = AdminType;
            // https://stackoverflow.com/questions/30405515/c-sharp-error-message-cannot-implicitly-convert-type
        }
// writes all member variable of this Admin object (including those in the        User  base  class)  to the  end of  the file  passed  in  as a parameter  and returns true if the write was successful
        public bool WriteAdminToFile(System.IO.StreamWriter file)
        {
            return true;
        }
        public override string GetFullUserString()
        {
            throw new NotImplementedException();
        }
    }
}
