using System.Runtime.InteropServices;

namespace Day_2
{
    internal class Program
    {
        public static void sum(int a,int b=2)
        {
            Console.WriteLine(a + b);
        }
        public static void sum(int a, int b,int c=3)
        {
            Console.WriteLine(a + b+c);
        }
        static void Main1(string[] args)
        {
            sum(1);
            sum(c: 2, a: 2, b: 1);
        }
    }
}
