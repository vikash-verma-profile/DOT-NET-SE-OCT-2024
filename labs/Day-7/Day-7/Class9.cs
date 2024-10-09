using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    //Anonymous  Type
    internal class Class9
    {
        public static void Main9()
        {
            var obj = new
            {
                Name="Vikash",
                Age=42

            };
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
        }
    }
}
