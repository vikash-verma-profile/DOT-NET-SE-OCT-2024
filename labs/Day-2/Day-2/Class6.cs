using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //class
    class Student
    {
        public int rollno;
        public string Name;
    }
    internal class Class6
    {
        public static void Main6()
        {
            //how to create an object
            /*
             * Multi line comment
             * 
             */
            Student s = new Student();
            s.rollno = 5;
            s.Name = "VIkash";
            Console.WriteLine(s.rollno);
            Console.WriteLine(s.Name);
        }
    }
}
