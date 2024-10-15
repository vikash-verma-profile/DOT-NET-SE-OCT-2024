using System.Collections;

namespace Day_9
{
    //collections
    internal class Program
    {
        static void Main0(string[] args)
        {
           Hashtable ht=new Hashtable();
            //     Key,  Value
            ht.Add("cs","cs.net");
            ht.Add("ora","oracle");
            ht.Add("vb", "vb.net");
            ht.Add("asp", "asp.net");
            ht.Add("zebra", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key: {item.Key} | Value : {item.Value}");
            }

            IDictionaryEnumerator en=ht.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Value);
            }
            Console.WriteLine("===========Sorted List==============");

            SortedList sl = new SortedList();
            //     Key,  Value
            sl.Add("cs", "cs.net");
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("asp", "asp.net");
            sl.Add("zebra", "asp.net");
            sl.Add("1", "asasd");
            sl.Add("2", 1.256);

            sl.Add("89", 1.256);
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"Key: {item.Key} | Value : {item.Value}");
            }
            Console.WriteLine("===========Sorted List GENERIC==============");
            SortedList<string,string> slG = new SortedList<string, string>();

            slG.Add("cs", "cs.net");
            slG.Add("ora", "oracle");
            slG.Add("vb", "vb.net");
            slG.Add("asp", "asp.net");
            slG.Add("zebra", "asp.net");

            foreach (KeyValuePair<string,string> item in slG)
            {
                Console.WriteLine($"Key: {item.Key} | Value : {item.Value}");
            }
        }
    }
}
