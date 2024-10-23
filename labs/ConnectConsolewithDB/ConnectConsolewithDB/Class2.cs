using ConnectConsolewithDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectConsolewithDB
{
    internal class Class2
    {
        public static void Main()
        {
            SampledbContext db = new SampledbContext();

            //Tblemployee tblemployee = new Tblemployee();
            //tblemployee.Name = "puran sharma";
            //tblemployee.Salary = 1000;
            //tblemployee.Gender = "M";
            //db.Add(tblemployee);
            //db.SaveChanges();

            //var employee = db.Tblemployees.Where(x => x.Id == 1).FirstOrDefault();
            //employee.Name = "kishore";
            //db.Update(employee);
            //db.SaveChanges();
            var employee = db.Tblemployees.FirstOrDefault(x => x.Id == 14);
            if (employee != null)
            {
                db.Tblemployees.Remove(employee);
            }
            db.SaveChanges();
            foreach (var item in db.Tblemployees)
            {
                Console.WriteLine($"ID :{item.Id}, Name:{item.Name}");
            }
        }
    }
}
