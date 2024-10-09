using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// Extension Method
    /// </summary>
    public static class StringExtensions
    {
        static StringExtensions()
        {

        }
        public static string ToFirstLetterUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
        public static void sample()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Class8
    {
        public static void Main8()
        {
            string orginal = "vikash verma";
            string result = orginal.ToFirstLetterUpperCase();
            Console.WriteLine(result);
            StringExtensions.sample();


        }
    }
}
