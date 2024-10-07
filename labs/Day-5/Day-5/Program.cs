namespace Day_5
{
    internal class Program
    {
        //equals vs ==
        static void Main0(string[] args)
        {
            string name = "Vikash";
            //string myname = name;
            //Console.WriteLine(name==myname);
            //Console.WriteLine(name.Equals(myname));

            char[] values = { 'V','i','k','a','s','h'};
            object mynewName = new string(values);
            Console.WriteLine("== operator result {0}", name == mynewName);
            Console.WriteLine("== operator result {0}", mynewName.Equals(name));
        }
    }
}
