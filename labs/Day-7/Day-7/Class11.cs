using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    //Generics

    public class GenericBox<T>
    {
        private T value;
        public GenericBox(T value)
        {
            this.value = value;
        }
        public T GetValue()
        {
            return value;
        }
        public void SetValue(T value)
        {
            this.value= value;
        }
    }
    internal class Class11
    {
        public static void swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        public static void Main()
        {
            //Create a generic box for integers
            GenericBox<int> intBox = new GenericBox<int>(123);
            Console.WriteLine(intBox.GetValue());

            GenericBox<string> strBox = new GenericBox<string>("Vikash Verma");
            Console.WriteLine(strBox.GetValue());

            int a=5,b= 10;
            Class11.swap<int>(ref a,ref b);
            Console.WriteLine("a:"+a+"b:"+b);

            string a1 = "Vikash", b1 = "Rakesh";
            Class11.swap<string>(ref a1, ref b1);
            Console.WriteLine("a1:" + a1 + "b1:" + b1);
        }
    }
}
