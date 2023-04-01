using Product;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no estoque: ");
            produto.Quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + produto);

            Console.Write("Digite o número de produtos a ser adicionado do estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: " + produto);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: " + produto);
        }
    }
}