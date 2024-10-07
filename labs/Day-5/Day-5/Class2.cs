using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public struct Person
    {
        public string Name;
        public int Age;
        public void PrintData(Person person)
        {
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
    }
    internal class Class2
    {
        public static void Main2()
        {
            Person person;
            person.Name = "Vikash Verma";
            person.Age = 42;
            person.PrintData(person);
            //Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
    }
}
