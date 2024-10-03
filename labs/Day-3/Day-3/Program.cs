namespace Day_3
{
    internal class Program
    {
        static void Main0(string[] args)
        {
            int Number1 = 20;
            object sampleObject = Number1; // implicit
            Console.WriteLine(sampleObject);

            int Number2 = (int)sampleObject;//explicit
            Console.WriteLine(Number2);

            int? SampleNumber = null;
            Nullable<int> SampleNumer2 = null;
            Console.WriteLine(SampleNumer2);
        }
    }
}
