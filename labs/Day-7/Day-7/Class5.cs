using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// Copy Constructor
    /// </summary>
    /// 
    public class Person
    {
        public string Name;
        public int Age;
        public string Address;

        public Person(string name,int age,string address)
        {
            Name = name;
            Age= age;
            Address = address;
        }

        //copy constructor
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
            Address = person.Address;
        }
        //Display Method
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
    internal class Class5
    {
        public static void Main5()
        {
            Person person = new Person("Vikash",42,"Banglore");
            Console.WriteLine("Original Person Details ==");
            person.DisplayDetails();

            Person copiedPerson = new Person(person);
            Console.WriteLine("\n Copied Person Details");
            copiedPerson.DisplayDetails();
        }
    }
}
