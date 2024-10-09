using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    public partial class Person1
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public void DisplayAddressInfo()
        {
            Console.WriteLine($"Address :{Address},City: {City}, Country:{Country}");
        }
    }
        
}
