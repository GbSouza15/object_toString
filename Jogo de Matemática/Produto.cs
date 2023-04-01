using System;
using System.Collections.Specialized;
using System.Globalization;

namespace Product
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public double ValorTotalEmEstoque()
        {
            double estoqueTotal = Preco * Quantidade;
            return estoqueTotal;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AdicionarProdutos(int q)
        {
            Quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            Quantidade -= q;
        }
    }
}
