using System;

namespace Exercicio7_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("ORIGEM");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
