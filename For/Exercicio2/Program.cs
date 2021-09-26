using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de valores a serem lidos: ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}

