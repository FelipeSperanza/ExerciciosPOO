using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de operações: ");
            double resultado = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = int.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = int.Parse(vet[1], CultureInfo.InvariantCulture);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    resultado = a / b;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
