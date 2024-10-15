using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    internal class Class2
    {
        public delegate void rectDelegate(double height,double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}",(width*height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0}", 2*(width * height));
        }
        public static void Main2()
        {
            Class2 c = new Class2();
            rectDelegate rect = new rectDelegate(c.perimeter);
            rect = rect + c.area;

            rect.Invoke(7.2,4.3);//area,//per
            rect = rect - c.area;
            Console.WriteLine();
            rect.Invoke(10,9);
        }
    }
}
