using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero para saber seus divisores: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if(x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
