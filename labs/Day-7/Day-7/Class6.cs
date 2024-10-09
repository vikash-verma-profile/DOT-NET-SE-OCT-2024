using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    public partial class Person1
    {
        private int abc;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person1(string firstName,string lastName,int age,int a)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            abc = a;
        }

        //Method to display details
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age:{Age}");
            Console.WriteLine("new="+abc);
        }
    }
    internal class Class6
    {
        public static void Main6()
        {
            Person1 person = new Person1("Vikash", "Verma", 42,12)
            {
                 Address="Banglore",
                 City="Banglore",
                 Country="India"
            };
            person.DisplayBasicInfo();
            person.DisplayAddressInfo();

        }
    }
}
