using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// static keyword Demo
    /// </summary>
    /// 
    public static class SampleStatic
    {
        static int id;
        public static void Print()
        {
            Console.WriteLine("I am being called from static class");
        }
    }
    public class Dummy
    {
        public Dummy()
        {
            Console.Write("I am being already created");
        }
        public static int id;
        int _id;
        public static void Print()
        {

            Console.WriteLine("I am being called from non -static class");
        }
    }
    internal class Class3
    {
        public static void Main3()
        {
            SampleStatic.Print();
            Dummy d = new Dummy();
            Dummy.Print();
            Dummy.id = 1;
            Console.WriteLine(ClassLibrary1.Class1.GetDate());

            Convert.ToInt32("2");

        }
    }
}
