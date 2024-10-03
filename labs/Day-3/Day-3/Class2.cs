using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{   
    //is vs as

    public class Student
    {

    }
    public class Person
    {

    }
    internal class Class2
    {
        public static void Main2()
        {
            Student s = new Student();
            object s1=new object();
            if(s1 is Person)
            {
                Console.WriteLine("s is an not an object of Person");
            }
            else if (s is object)
            {
                Console.WriteLine("s is an object of Student");
            }
            else
            {
                Console.WriteLine("No object");
            }
        }
    }
}
