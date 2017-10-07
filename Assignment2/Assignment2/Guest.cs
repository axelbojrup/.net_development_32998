using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Guest : User
    {
        private DateTime dateOfBirth;

        public Guest(string username, string password, string firstName, string lastName, int ratingsCount, float averageRating, DateTime dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ratingsCount = ratingsCount;
            this.dateOfBirth = dateOfBirth;
        }

// writes all member variable of this Admin object (including those in the User  base  class)    to the  end of  the file  passed  in  as  a parameter  and returns true if the write was successful.
        public bool WriteGuestToFile(System.IO.StreamWriter file)
        {
            return true;
        }

// overrides  base  class  version, returns a string with firstName, lastName, and dateOfBirth.
        public override string GetFullUserString()
        {
            throw new NotImplementedException();
        }
    }
}
