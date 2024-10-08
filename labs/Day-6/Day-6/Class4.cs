using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    public class Sum
    {
        public int Number1;
        public Sum(int num1)
        {
            Number1 = num1;
        }
        public static Sum operator +(Sum s1,Sum s2)
        {
            //option-1
            //Sum s3 = new Sum(0);
            //s3.Number1 = s1.Number1 + s2.Number1;
            //return s3;

            //option-2
            //Sum s3= new Sum(s1.Number1 + s2.Number1);
            //return s3;

            //option-3
            return new Sum(s1.Number1 + s2.Number1);
        }
        public void Print()
        {
            Console.WriteLine("Adding two object Numbers :"+Number1);
        }
    }
    internal class Class4
    {
        public static void Main4()
        {
            Sum s1 = new Sum(1);
            Sum s2=new Sum(2);
            Sum sum3=new Sum(0);
            int a=1, b=3;
            int c = a + b;
            sum3 = s1 + s2;
            sum3.Print();
        }
    }
}
