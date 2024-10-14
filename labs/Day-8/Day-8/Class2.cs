using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{

    public class InvalidOrderException : Exception
    {
        public int OrderId { get; set; }
        public InvalidOrderException()
        {
                
        }
        public InvalidOrderException(string message) : base(message)
        {

        }
        public InvalidOrderException(string message, Exception innerExecption) : base(message, innerExecption)
        {

        }
        public InvalidOrderException(string message,int orderId) : base(message)
        {
            OrderId= orderId;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Order ID:{OrderId}";
        }
    }
    internal class Class2
    {
        public static void Main2()
        {
            try
            {
                ProcessOrder(10001);
            }
            catch (InvalidOrderException ex)
            {
                Console.WriteLine("Custom exception cought");
                Console.WriteLine($"Message: {ex.Message }");
                Console.WriteLine($"Order Id: {ex.OrderId}");
                Console.WriteLine(ex.ToString());
            }
        }
        static void ProcessOrder(int OrderId)
        {
            bool isOrderValid = false;
            if (!isOrderValid)
            {
                throw new InvalidOrderException("Invalid Order Proccessed", OrderId);
            }
            Console.WriteLine("Order processed successfully");
        }
    }
}
