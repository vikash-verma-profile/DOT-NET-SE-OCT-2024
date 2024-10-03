using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Class1
    {
        public static void Main1()
        {
            int? userAge = GetUserFromDatabase("Vikash");
            string sample = null;
            string? sample1=null;
            //Nullable<string> sample3 = null;// here string will give error

            if (userAge.HasValue)
            {
                Console.WriteLine($"User's age is {userAge.Value}");
            }
            else
            {
                Console.WriteLine("User's age is not provided");
            }

            userAge = GetUserFromDatabase("arjun");

            if (userAge.HasValue)
            {
                Console.WriteLine($"User's age is {userAge.Value}");
            }
            else
            {
                Console.WriteLine("User's age is not provided");
            }

        }
        public static int? GetUserFromDatabase(string username)
        {
            if (username == "vikash")
            {
                return null;
            }
            else if (username == "arjun")
            {
                return 30;
            }
            return null;
        }
    }
}
