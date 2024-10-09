using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    /// <summary>
    /// Sealed Keyword Demo
    /// </summary>
    public sealed class PaymentProcesser
    {
        public void ProcessPayment(string paymentMethod)
        {
            Console.WriteLine($"Processing payment through {paymentMethod}");
            if (paymentMethod == "creditcard")
            {
                Console.WriteLine("Processing credit card payment");
            }
            else if (paymentMethod == "paypal")
            {
                Console.WriteLine("Processing paypal payment ");
            }
            else
            {
                Console.WriteLine("Invalid payement method");
            }
        }
        public void GenerateRecipt()
        {
            Console.WriteLine("Generating recipt");
        }
    }
    internal class Class2
    {
        public static void Main2()
        {
            PaymentProcesser processer = new PaymentProcesser();
            processer.ProcessPayment("creditcard");
            processer.GenerateRecipt();

        }
    }
}
