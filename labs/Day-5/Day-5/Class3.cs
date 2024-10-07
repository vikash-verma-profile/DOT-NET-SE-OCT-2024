using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public enum WeekDays
    {
        Sunday=1,
        Monday=2,
        Tuesday=3,
        Wednesday=4,
        Thursday=5,
        Friday=6,
        Saturday=7,
    }
    internal class Class3
    {
        public static void Main3()
        {
            System.Console.WriteLine((int)WeekDays.Sunday);
            System.Console.WriteLine((int)WeekDays.Saturday);
        }
    }
}
