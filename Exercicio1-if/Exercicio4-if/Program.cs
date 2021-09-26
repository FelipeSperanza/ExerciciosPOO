using System;

namespace Exercicio4_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a hora inicial e a hora final: ");
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int horas = 0;

            if (a == b)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (b > a)
            {
                horas = b - a;
                Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
            }
            else
            {
                horas = (24 - a) + b;
                Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
            }
        }
    }
}
