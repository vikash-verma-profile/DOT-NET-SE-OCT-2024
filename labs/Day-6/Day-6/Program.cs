namespace Day_6
{
    abstract class SampleAbstract
    {
        public void Display()
        {
            Console.WriteLine("I am display");
        }
        public abstract void Print2();
    }
    interface ISample {
        void Print(); //signature
    }
    class Sample : SampleAbstract,ISample
    {
        public void Print()
        {
            Console.WriteLine("I am defined in class but declared in interface");
        }
        public override void Print2()
        {
            Console.WriteLine("I am defined in class but declared in Abstract class");
        }
    }
    internal class Program
    {
        static void Main0(string[] args)
        {
            Sample sample = new Sample();
            sample.Print();

           sample.Print2();
        }
    }
}
