using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            Console.Write("Entre com a quantidade de pessoas: ");
            int x = int.Parse(Console.ReadLine());

            double[] vet = new double[x];

            for (int i = 0; i < x; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += vet[i];
            }

            media = media / x ;
            Console.WriteLine("A MÉDIA É: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
