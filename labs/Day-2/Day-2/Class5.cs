using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class5
    {
        public static void Main5()
        {
            System.Console.WriteLine();
            string y = "3asd";

            //int res=int.Parse(y);
            //Console.WriteLine(res); 
            int result;
            bool isConverted = int.TryParse(y, out result);
            if (isConverted)
            {
                Console.WriteLine($"value after converting {result}");
            }
            else
            {
                Console.WriteLine("Its not a number");
            }
        }
    }
}
