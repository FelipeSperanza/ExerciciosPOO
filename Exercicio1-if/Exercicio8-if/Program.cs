using System;
using System.Globalization;

namespace Exercicio8_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario < 2000)
            {
                imposto = 0;
                Console.WriteLine("ISENTO");

            }
            else if (salario < 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine("RS " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario < 45000)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine("RS " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("RS " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
