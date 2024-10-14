using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day_8
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Class5
    {
        public static void Main() {


            Console.WriteLine("=======List============");
            List<int> list=new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(1);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id=1,Name="Vikash"});
            employees.Add(new Employee() { Id = 2, Name = "Rahul" });
            foreach (var item in employees)
            {
                Console.WriteLine(item.Name);

            }
            Console.WriteLine("=======Dictionary============");
            Dictionary<int, string> keys = new Dictionary<int, string>();

            keys.Add(1,"C#");
            keys.Add(2, "Java");
            keys.Add(3, "vikash");

            foreach (var item in keys)
            {
                Console.WriteLine(item.Key +item.Value);

            }

            Console.WriteLine("=======Stack=LIFO===========");
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======Non Generic Stack============");
            Stack stn = new Stack();
            stn.Push(1);
            stn.Push(2);
            stn.Push("Vikash");
            stn.Pop();

            foreach (var item in stn)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======Queue=FIFO===========");
            Queue<int> qt = new Queue<int>();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            qt.Dequeue();
            foreach (var item in qt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======Non Generic Queue============");
            Queue qn = new Queue();
            qn.Enqueue(1);
            qn.Enqueue(2);
            qn.Enqueue("Vikash");

            foreach (var item in qn)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======ArrayList============");
            ArrayList al = new ArrayList();
            string stf = "Vikash";
            int x = 9;
            al.Add(x);
            al.Add(st);
            foreach (var item in al)
            {
                Console.WriteLine(item);

            }

        
        }
    }
}
