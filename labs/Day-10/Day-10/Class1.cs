using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Class1
    {
        public static void Main()
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Vikash";

            List<Employee> list = new List<Employee>();
            list.Add(emp);
            list.Add(new Employee() { Id=102,Name="Mohan"});
            string listJson= JsonConvert.SerializeObject(list);
            string jsonValue=JsonConvert.SerializeObject(emp);
            Console.WriteLine(jsonValue);
            Employee emp1=JsonConvert.DeserializeObject<Employee>(jsonValue);
            Console.WriteLine($"ID: {emp1.Id} , Name: {emp1.Name}");
            Console.WriteLine(listJson);

            foreach (var item in JsonConvert.DeserializeObject<List<Employee>>(listJson))
            {
                Console.WriteLine($"ID: {item.Id},Name :{item.Name}");
            }
        }
    }
}
