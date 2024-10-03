using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Class4
    {
        public static void Main4()
        {
            //string name = "MOM";
            //Console.WriteLine(name);
            //Console.WriteLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(name[i]+",");
            //}
            //Console.WriteLine();
            //Console.WriteLine("========================");
            //for (int i = name.Length-1; i >=0; i--)
            //{
            //    Console.Write(name[i] + ",");
            //}

            string name = "My Name is vikash Verma";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Substring(0,5));
            Console.WriteLine(name.Replace("vikash", "Rahul"));
            var sampleArray=name.Split(' ');
            string newValie = "1,2,34,213,123";
            var sampleArrayComma = newValie.Split(',');
            for (int i = 0; i < sampleArrayComma.Length; i++) { 
                Console.WriteLine($"{sampleArrayComma[i]}");
            }
        }
    }
}
