namespace ConnectConsolewithDB
{
    //linq
    internal class Program
    {
        static void Main0(string[] args)
        {
            int[] numbers = [5, 10, 8, 9, 20, 9, 78];

            //Method syntax
            List<int> query = numbers.Where(x => x % 2 == 0).ToList();
            IEnumerable<int> query1 = numbers.Where(x => x % 2 == 0);
            Console.WriteLine("Even Numbers");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Even Numbers BY query");
            //query
            IEnumerable<int> query2=from num in numbers where num % 2 == 0 select num;
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
