using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class A
    {
        int a;
        public A(int a)
        {
            Console.WriteLine("A");
            this.a = a;
            Console.WriteLine(a);
        }
    }
    class B:A
    {
        public B(int a):base(a)
        {
            Console.WriteLine("B");
        }
    }
    class C:B
    {
        public C(int a):base(a)
        {
            Console.WriteLine("C");
        }
    }
    internal class Class3
    {
        public static void Main3()
        {
            C c = new C(1);
        }
    }
}
