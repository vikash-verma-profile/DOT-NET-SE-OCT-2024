using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    //shadowing or method hiding

    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display method from Baseclass");
        }
        public virtual void  Show()
        {
            Console.WriteLine("Show method from Baseclass");
        }
    }
    public class DerviedClass : BaseClass
    {
        //method hiding using new keyword
        public new void Display()
        {
            Console.WriteLine("DIsplay method from dervied class");

        }

        public override void Show()
        {
            Console.WriteLine("Show method from dervied");
        }
    }
    internal class Class1
    {
        public static void Main1()
        {
            DerviedClass d = new DerviedClass();
            d.Display();

            BaseClass baseDerviedObj = new DerviedClass();
            baseDerviedObj.Display();//method hiding
            baseDerviedObj.Show();// overriding
        }
    }
}
