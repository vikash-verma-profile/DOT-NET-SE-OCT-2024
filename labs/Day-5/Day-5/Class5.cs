using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class A
    {
        public string msg()
        {
            return "this is A class method";
        }
    }
    class B : A
    {
        public string info()
        {
            msg();
            return "this is B class Methd";
        }
        public class C : A { 
        
            public string getInfo()
            {
                string mesasgeFormA=msg();
                return "this is C class Method and FROM A :"+ mesasgeFormA;
            }
        }
    }
    
    class D : A { }
    internal class Class5
    {
        public static void Main()
        {
            B.C c1 = new B.C();
            Console.WriteLine(c1.getInfo());
        }
    }
}
