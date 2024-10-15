using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    //Lambda  =>
    internal class Class6
    {
        delegate int square(int number);

        delegate int Multiply(int x, int y);

        //lamda with a block of code

        delegate void PrintMessage(string message);
        public static void Main6()
        {
            square s=x=>x*x;
            Multiply m= (x, y) => x * y;
            int result = s(5);
            Console.WriteLine(result);
            int result1 = m(5,10);
            Console.WriteLine(result1);

            PrintMessage print = message =>
            {
                Console.WriteLine(message);
            };
            print("Vikash");

            int[] numbers = {2,3,4,5,6};

            var evennumbers = numbers.Where(x => x % 2 == 0).ToList();
            foreach (var item in evennumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
