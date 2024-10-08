using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    //late bindings dynmaic polymorphism overriding

    public class SampleBase
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi I am from base class");
        }
    }
    public class SampleDerived:SampleBase
    {
        public override void Print()
        {
            Console.WriteLine("Hi I am from Derived class");
        }
    }
    internal class Class5
    {
        public static void Main()
        {
            SampleDerived objSampleDerived = new SampleDerived();
            objSampleDerived.Print(); //==> calling derived
            SampleBase obj = new SampleDerived();
            obj.Print();
        }
    }
}
