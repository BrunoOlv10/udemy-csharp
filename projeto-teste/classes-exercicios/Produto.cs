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

        public List<Produto> ObterProdutos()
        {
            return ProdutosEmpresa;
        }

        public static void ObterInfosAlterarPreco(ProdutoEmpresa produtoEmpresa)
        {
            Console.Write("Qual a categoria que será alterado o preço? ");
            string categoriaEscolhida = Console.ReadLine();

            bool categoriaExiste = produtoEmpresa.ObterProdutos().Any(p => p.Categoria == categoriaEscolhida);

            if (!categoriaExiste)
            {
                Console.WriteLine();
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            Console.Write("Quanto será o aumento, em porcentagem, do preço do produto (sem o sinal %)? ");
            int porcentagemAumento = Convert.ToInt32(Console.ReadLine());

            List<Produto> ProdutosComAumento = produtoEmpresa.AlterarPrecoPorCategoria(categoriaEscolhida, porcentagemAumento);

            produtoEmpresa.ListarProdutosPrecosReajustados(ProdutosComAumento, categoriaEscolhida);
        }

        public List<Produto> AlterarPrecoPorCategoria(string categoriaEscolhida, int porcentagemAumento)
        {
            List<Produto> ProdutosComAumento = new List<Produto>();

            foreach (var item in ProdutosEmpresa)
            {
                if (item.Categoria == categoriaEscolhida)
                {
                    double calcularAumento = (porcentagemAumento / 100.0);
                    item.Preco += item.Preco * calcularAumento;
                    ProdutosComAumento.Add(item);
                }
            }

            return ProdutosComAumento;
        }

        public void ListarProdutosPrecosReajustados(List<Produto> ProdutosComAumento, string categoriaEscolhida)
        {
            Console.WriteLine();
            Console.WriteLine($"Os produtos da categoria '{categoriaEscolhida}' com os preços atualizados:");
            foreach (var produto in ProdutosComAumento)
            {
                Console.WriteLine($"Id: {produto.Id} - Nome: {produto.NomeProduto} - Categoria: {produto.Categoria} - Preço Reajustado: {produto.Preco}");
            }
        }

        public void ListarProdutos()
        {
            Console.WriteLine();
            Console.WriteLine("Esses são os produtos da empresa:");
            foreach (var produto in ProdutosEmpresa)
            {
                Console.WriteLine($"Id: {produto.Id} - Nome: {produto.NomeProduto} - Categoria: {produto.Categoria} - Preço: {produto.Preco}");
            }
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

        //public List<Produto> ObterProdutosPorNome()
        //{
        //    return ProdutosEmpresa.OrderBy(p => p.NomeProduto).ToList();
        //}
    }
}
