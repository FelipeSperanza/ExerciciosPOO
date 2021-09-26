using System;
using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar: ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal = ConversorDeMoeda.ValorPago(cotacao, dolares);

            Console.WriteLine("Valor a ser pago em reais: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
