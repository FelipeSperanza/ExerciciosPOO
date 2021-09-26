using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;
using System;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Brith date: (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, c1, status);


            Console.Write("How many item to this order: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #i item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product p1 = new Product(productName, productPrice);

                Console.Write("Quantify: ");
                int quantify = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantify, productPrice, p1);

                order.AddItem(orderItem);

                Console.WriteLine();
                Console.WriteLine("Order Sumary: ");
                Console.WriteLine(order);
                
            }

        }
    }
}
