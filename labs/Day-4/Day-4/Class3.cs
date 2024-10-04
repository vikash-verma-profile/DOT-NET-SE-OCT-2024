using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class Class3
    {
        public static void Main()
        {
            Emp[] EmpList = new Emp[1];

            Console.WriteLine("Please enter Employee ID");
            Emp e = new Emp();
            e.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Name");
            e.Name = Console.ReadLine();
            EmpList[0] = e;

            for (int i = 0; i < EmpList.Length; i++)
            {
                Console.WriteLine($"Employee ID :{EmpList[i].ID} Employee Name : {EmpList[i].Name}"); 
            }
        }
    }
}
