using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class1
    {
        public static void Swap(ref int a,ref int b) {

            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping a:{a} b:{b}");
        }

        public static void SumOut(int a,int b,out int c)
        {
            c= a + b;
        }
        public static void SumRef(ref int a, ref int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main2()
        {
            int a=1,b = 2;
            //Console.WriteLine($"before swapping a:{a} b:{b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"after swapping in MAIN a:{a} b:{b}");
            int result;
            SumOut(1, 2, out result);
            Console.WriteLine(result);
            SumRef(ref a,ref b);
        }
    }
}
