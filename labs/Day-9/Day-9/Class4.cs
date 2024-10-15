using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{

    internal class Class4
    {
        public delegate void Sample(string pet);
        public static void Identity(Sample mypet,string color)
        {
            color = " Black " + color;
            mypet(color);
        }
        public static void Main4()
        {

            Sample p = delegate (string mypet)
            {
                Console.WriteLine("My pet is {0} ",mypet);
            };
            p("Dog");

            Identity(delegate(string color)
            {
                Console.WriteLine("The color "+ "of my dog is {0}",color);
            },"White");

        }
    }
}
