using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_8
{
    internal class Class4
    {
        public static void Main4()
        {
            string pattern = "[a-z][0-9]";
            string pattern1 = @"\b[M]\w+";
            string patten2 = @"\d+";
            Regex rg = new Regex(patten2);
            if (rg.IsMatch(" asas 6 asd"))
            {
                Console.WriteLine("Matches");
            }
            else
            {
                Console.WriteLine("Not a valid match");
            }
        }
    }
}
