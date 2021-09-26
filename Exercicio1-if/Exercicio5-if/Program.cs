using System;
using System.Globalization;

namespace Exercicio5_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valor = 0.0;

            if (codigo == 1)
            {
                valor = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                valor = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                valor = quantidade * 5;
            }
            else if (codigo == 4)
            {
                valor = quantidade * 2;
            }
            else
            {
                valor = quantidade * 1.5;
            }
            Console.WriteLine("TOTAL: RS " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
