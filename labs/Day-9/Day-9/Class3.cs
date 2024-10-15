using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    //Func vs Action vs Predicate
    /// <summary>
    /// Func==> one input and output variable it have
    /// Action==> only input parameters
    /// Predicate===>
    /// </summary>
    internal class Class3
    {
        public  int Method(int num)
        {
            return num;
        }
        public static void MethodA(int num)
        {
            Console.WriteLine(num);
        }
        public static bool MethodP(int num)
        {
            if (num > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main3()
        {
            Class3 c = new Class3();
            Func<int, int> myfuncDelegate = c.Method;
            Console.WriteLine(myfuncDelegate(10));

            Action<int> actionDelegate= MethodA;
            actionDelegate(20);

            Predicate<int> predicateDelegate = MethodP;
            Console.WriteLine(predicateDelegate(20));

            //anonymous method
            Predicate<string> val = delegate (string s)
            {
                if (s.Length < 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            Console.WriteLine(val("Vikash"));

            //lamda expressions
            Predicate<string> sample = str => str.Equals(str.ToLower());
            Console.WriteLine(sample("Rakesh"));
        }
    }
}
