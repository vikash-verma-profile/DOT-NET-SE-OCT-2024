using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    public class OverLoadingDemo
    {

        //compiler time polymoprphism/ early bindings/ overloading
        //constructor overloading or constructor chaining 
        public OverLoadingDemo()
        {

        }
        public OverLoadingDemo(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public OverLoadingDemo(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

        //method overloading
        public void Sum()
        {
            Console.WriteLine(1+2);
        }
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

        public void Sum(string a,string b)
        {
            Console.WriteLine((Convert.ToInt32(a) + Convert.ToInt32(b)));
        }
    }
    internal class Class3
    {
        public static void Main3()
        {
            OverLoadingDemo d=new OverLoadingDemo();
            d.Sum();
            d.Sum(1, 2);
            d.Sum("1", "5");
            d.Sum(1, 2, 3);

        }
    }
}
