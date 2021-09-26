using System;
using Exemplo.Entities;
using Exemplo.Entities.Enums;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

            Console.WriteLine(order);
        }
    }
}
