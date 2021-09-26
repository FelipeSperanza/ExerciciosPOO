using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;   // forma simplificada de dizer que a variavel (tipo valor) será nulá

            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //Mostra o valor e caso não tenha, mostra o valor padrao 0;
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);  // Diz se há algum valor na variavel
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }


            // OPERADOR DE COALESCÊNCIA NULA

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);


        }
    }
}
