using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLibrary;

namespace Day_5
{
    internal class Class1
    {
        public static void Main1()
        {
            var a = 1;
            Console.WriteLine(a);
            Calculator obj = new Calculator();
            Console.WriteLine(obj.Sum(1, 2));
            if (a == 1)
            {
                Console.WriteLine("Value of a is "+a);
            }
        }
    }
}
