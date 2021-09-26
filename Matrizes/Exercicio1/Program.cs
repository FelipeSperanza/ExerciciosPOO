using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int negativos = 0;

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine();

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();


            for(int i = 0; i< n; i++)
            {
                for (int j = 0; j< n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        negativos += 1;
                    }
                }
            }

            Console.WriteLine("Negative Numbers = " + negativos);


        }
    }
}
