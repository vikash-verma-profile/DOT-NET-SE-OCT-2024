using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// Types of constructors
    /// </summary>
    /// 
    public class SampleConst
    {
        //default
        //public SampleConst()
        //{

        //}

        //private
        private SampleConst()
        {

        }
        public static SampleConst GetInstance()
        {
            return new SampleConst();

        }

        //perameterized
        //public SampleConst(int a)
        //{
        //    Console.WriteLine("Value of a is "+a);
                
        //}

        //static
        //static SampleConst()
        //{
        //    Console.WriteLine("I am static constructor");
        //}

        public void Print()
        {
            Console.WriteLine("Print some value");
        }
    }
    internal class Class4
    {
        public static void Main()
        {
            SampleConst s =SampleConst.GetInstance();
            s.Print();
        }
    }
}
