using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            Console.Write("Digite a quantidade de produtos: ");
            int x = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto() { Nome = nome, Preco = preco };
                media += vet[i].Preco;
            }

            media = media / x;
            Console.WriteLine("MEDIA: " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
