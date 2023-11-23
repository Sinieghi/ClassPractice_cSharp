using System;

namespace Practice

{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new()
            {
                Id = 1116,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            string tx = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(tx);
        }
    }
}