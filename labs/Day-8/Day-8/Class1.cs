using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    internal class Class1
    {
        public static void Main1()
        {
            try
            {
                ThrowException();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Exception " +ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner execption"+ex.InnerException.Message);
                }
            }
        }

        static void ThrowException()
        {
            try
            {
                int a = 10, b = 0;
                int result = a / b;
            }
            catch(DivideByZeroException ex)
            {
                throw new ArithmeticException("An error occured due to arithemetic",ex);
            }
        }

    }
}
