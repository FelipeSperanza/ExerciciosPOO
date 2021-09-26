using System;

namespace Exercicio3_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores: ");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a > b)
            {
                if(a % b == 0)
                {
                    Console.WriteLine("MULTIPLOS");
                }
                else
                {
                    Console.WriteLine("NÃO SÃO MULTIPLOS");
                }
            }
            else
            {
                if (b % a == 0)
                {
                    Console.WriteLine("MULTIPLOS");
                }
                else
                {
                    Console.WriteLine("NÃO SÃO MULTIPLOS");
                }
            }
        }
    }
}
