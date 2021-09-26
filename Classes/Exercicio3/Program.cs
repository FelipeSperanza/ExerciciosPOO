using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");

            Produto p1 = new Produto();
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(p1);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine();
            Console.WriteLine(p1);



        }
    }
}
