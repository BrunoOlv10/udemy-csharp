using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class Produto
    {
        public string Id { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public Produto(string id, string nomeProduto, string categoria, double preco)
        {
            this.Id = id;
            this.NomeProduto = nomeProduto;
            this.Categoria = categoria;
            this.Preco = preco;
        }
    }

    public class ProdutoEmpresa
    {
        List<Produto> ProdutosEmpresa = new List<Produto>();

        public List<Produto> AdicionarProduto(Produto produto)
        {
            ProdutosEmpresa.Add(produto);

            return ProdutosEmpresa;
        }

        public void ListarProdutos()
        {
            Console.WriteLine();
            Console.WriteLine("Atualmente esses são os produtos da empresa:");
            foreach (var produto in ProdutosEmpresa)
            {
                Console.WriteLine($"Id: {produto.Id} - Nome: {produto.NomeProduto} - Categoria: {produto.Categoria} - Preço: {produto.Preco}");
            }
        }

        public List<Produto> ObterProdutosPorNome()
        {
            return ProdutosEmpresa.OrderBy(p => p.NomeProduto).ToList();
        }

        public Dictionary<string, List<Produto>> AgruparProdutosPorCategoria()
        {
            Dictionary<string, List<Produto>> ProdutosAgrupadosPorCategoria = new Dictionary<string, List<Produto>>();

            foreach (var item in ProdutosEmpresa)
            {
                if (!ProdutosAgrupadosPorCategoria.ContainsKey(item.Categoria))
                {
                    ProdutosAgrupadosPorCategoria[item.Categoria] = new List<Produto>();
                }

                ProdutosAgrupadosPorCategoria[item.Categoria].Add(item);
            }

            return ProdutosAgrupadosPorCategoria;
        }

        public void ListarProdutoAgrupadosPorCategoriaComTotais()
        {
            var produtosAgrupados = AgruparProdutosPorCategoria();
            double totalGeral = 0;

            foreach (var categoria in produtosAgrupados)
            {
                Console.WriteLine($"Categoria: {categoria.Key}");
                double subtotal = 0;

                foreach (var produto in categoria.Value)
                {
                    Console.WriteLine($"Id: {produto.Id}, Nome: {produto.NomeProduto}, Preço: {produto.Preco}");
                    subtotal += produto.Preco;
                }

                Console.WriteLine($"Subtotal da categoria '{categoria.Key}': {subtotal:C2}\n");

                totalGeral += subtotal;
            }

            Console.WriteLine($"Total Geral de Todos os Produtos: {totalGeral:C2}");
        }
    }
}
