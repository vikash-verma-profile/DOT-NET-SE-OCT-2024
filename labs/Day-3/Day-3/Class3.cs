using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Employee
    {

    }
    public class Manager
    {

    }
    internal class Class3
    {
        public static void Main3()
        {
            object[] o=new object[4];
            o[0] = new Employee();
            o[1] = new Student();
            o[2] = 6767;
            o[3] = "Vikash";
            for (int i = 0; i < 4; i++)
            {
                int? s = o[i] as int?;
                if (s != null)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("is not a string");
                }
            }

        }
    }
}
