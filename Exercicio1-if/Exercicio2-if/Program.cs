using System;

namespace Exercicio2_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}
