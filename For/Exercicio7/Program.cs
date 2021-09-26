using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor: ");
            int n = int.Parse(Console.ReadLine());
            double quadrado = 0, cubo = 0;

            for (int i = 1; i <= n; i++)
            {
                quadrado = Math.Pow(i, 2);
                cubo = Math.Pow(i, 3);


                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
