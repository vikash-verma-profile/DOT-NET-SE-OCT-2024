using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// Indexer in c#
    /// </summary>
    /// 
    class SampleCollection
    {
        private string[] collection = new string[3];
        public string this[int index]
        {
            get
            {
                return collection[index];
            }
            set
            {
                collection[index] = value;
            }
        }
        internal class Class10
        {
            public static void Main10()
            {
                SampleCollection sample = new SampleCollection();
                sample[0] = "Vikash";
                sample[1] = "Rakesh";
                Console.WriteLine(sample[0]);
                Console.WriteLine(sample[1]);
            }
        }
    }
}
