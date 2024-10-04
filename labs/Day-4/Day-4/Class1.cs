using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class Student
    {
       private int rollno;
       private string Name;
        public int RollNO
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public void Print()
        {
            Console.WriteLine($"Roll NO : {rollno}");
        }
    }

    public class Distributer
    {
        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        //auto propeties
        public int SampleProp { get; set; }


        private double _discount=10;
     
        public void GetDiscount()
        {
            Console.WriteLine(Price*(_discount/100));
        }

        public Distributer()
        {
                
        }
        ~Distributer()
        {

        }
    }
    internal class Class1
    {
        public static void Main1()
        {
            Student student=new Student();
            student.RollNO = 101;
            Console.WriteLine(student.RollNO);
            student.Print();
            Distributer distributer=new Distributer();
            distributer.Price = 100;
            distributer.GetDiscount();
        }
    }
}
