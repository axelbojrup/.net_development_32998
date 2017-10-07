using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class User
    {
        protected string username, password, firstName, lastName;
        protected int ratingsCount;

        public int RatingsCount
        {
            get
            {
                return ratingsCount;
            }
        }

        protected double averageRating;

        public double AverageRating
        {
            get
            {
                return averageRating;
            }
        }

// concrete  method,  checks  the  username  and  password parameters against  the member  variables and  return  true  if  they match and returns false otherwise.
        public bool CheckUserNameAndPassword(string username, string password)
        {
            return true;
        }
// concrete method, returns astring containing the username and first name only.
        public string GetShortUserString()
        {
            return "";
        }
// concrete method, updates the averageRating and ratingsCount member variables with the given parameter.
        public void AddRating(int rating)
        {

        }

        public abstract string GetFullUserString();
    }
}
