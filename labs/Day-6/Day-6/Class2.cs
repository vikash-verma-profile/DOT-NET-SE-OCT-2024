using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class A
    {
        private int Number1;
        protected int Number2;
        public int Number3;
        internal int Number4;
        protected internal int Number5;
    }
    class B:A
    {
        public void Display()
        {
            Console.WriteLine(Number4);
        }
    }
    internal class Class2
    {
        public static void Main2()
        {
            A a = new A();
            a.Number3 = 1;
            a.Number5 = 2;
            a.Number4 = 2;
            ClassLibrary1.Class1 temp = new ClassLibrary1.Class1();
           
        }
    }
}
