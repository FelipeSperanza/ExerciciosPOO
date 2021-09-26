using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int x = int.Parse(Console.ReadLine());

            Quarto[] vet = new Quarto[10];

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Rent #" + i + ": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[room] = new Quarto { Nome = name, Email = email, Room = room };
            }

            for (int i = 0; i < 10; i++)
            {
                if(vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i].Nome + ", " + vet[i].Email);
                }
            }
        }
    }
}
