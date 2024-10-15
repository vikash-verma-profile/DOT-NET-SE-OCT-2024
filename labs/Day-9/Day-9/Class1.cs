using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    //delegate

    // [modifier] delegate [return-type]  [deletegate-name]([paraemeters])

    public delegate void add(int a, int b);
    internal class Class1
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main1()
        {
            Class1 c = new Class1();
            add addDel = new add(c.Sum);
            addDel(1, 23);
            addDel.Invoke(1, 23);
        }
    }
}
