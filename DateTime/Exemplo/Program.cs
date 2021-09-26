using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtores

            DateTime d1 = new DateTime(2021,08,30);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2021, 08, 30, 20, 30, 05);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2021, 08, 30, 20, 30, 05, 500);
            Console.WriteLine(d3);

            //Builders

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
            

        }
    }
}
