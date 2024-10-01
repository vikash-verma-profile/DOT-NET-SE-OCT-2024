using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class2
    {
        //var vs dynamic
        public static void Main3()
        {
            var i = 1;
            //i = "Vikash";
            Console.WriteLine(i);

            dynamic y = 1;
            y = "Vikash"; //auto typecasting
            Console.WriteLine(y);
        }
    }
}
