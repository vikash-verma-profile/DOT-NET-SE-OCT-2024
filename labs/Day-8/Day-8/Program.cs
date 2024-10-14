using System.Diagnostics;
using Sample;

namespace Day_8
{
    //Exception
    internal class Program
    {
        static void Main0(string[] args)
        {
            try
            {
                int a = 0, b = 5;
                int c = 6;
               // int c = b / a;
                Console.WriteLine(c);
                Sample.Class1 class1 = new Sample.Class1();
                class1.SampleMethod();

            }
            //catch(DivideByZeroException ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
               
                Console.WriteLine("Some error Occured");
            }
            finally
            {
                Console.WriteLine("I am finally block");
            }
            
        }
    }
}
