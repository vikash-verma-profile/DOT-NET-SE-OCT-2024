using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class7
    {
        public static void Main()
        {
            string Name = "Vikash";
            Name = "Vikash Verma";
            Console.WriteLine(Name);
            StringBuilder s=new StringBuilder();
            s.Append("Vikash");
            s.Append(" Verma");
            Console.WriteLine("===================");
            Console.WriteLine(s);
        }
    }
}
