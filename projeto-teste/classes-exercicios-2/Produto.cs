using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios;

namespace projeto.classes_exercicios_2
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, string categoria, double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Preco = preco;
        }
    }

    public class ProdutoEmpresa
    {
        List<Produto> ProdutosEmpresa = new List<Produto>();

        public (List<Produto>, bool existe) AdicionarProdutos(Produto produto)
        {
            bool existe = ProdutosEmpresa.Any(p => p.Id == produto.Id || p.Nome == produto.Nome);

            if (!existe)
            {
                ProdutosEmpresa.Add(produto);
            }

            return (ProdutosEmpresa, existe);
        }

        public void ListarProdutos()
        {
            if (ProdutosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum produto cadastrado");
            }

            else
            {
                Console.WriteLine("Produtos: ");
                foreach (var produto in ProdutosEmpresa)
                {
                    Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço: {produto.Preco:F2}");
                }
            }
        }

        public void OrdenarNome(string ordenacao)
        {
            if (ProdutosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum produto cadastrado");
            }

            else
            {
                if (ordenacao == "asc")
                {
                    ProdutosEmpresa = ProdutosEmpresa.OrderBy(p => p.Nome).ToList();
                }

                else if (ordenacao == "desc")
                {
                    ProdutosEmpresa = ProdutosEmpresa.OrderByDescending(p => p.Nome).ToList();
                }

                foreach (var produto in ProdutosEmpresa)
                {
                    Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço: {produto.Preco:F2}");
                }
            }
        }

        public void ListarCategorias()
        {
            if (ProdutosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum produto cadastrado");
            }

            else
            {
                Dictionary<string, double> TotalPreco = new Dictionary<string, double>();
                double totalGeral = 0;

                foreach (var produto in ProdutosEmpresa)
                {
                    if (TotalPreco.ContainsKey(produto.Categoria))
                    {
                        TotalPreco[produto.Categoria] += produto.Preco;
                    }

                    else
                    {
                        TotalPreco.Add(produto.Categoria, produto.Preco);
                    }

                    totalGeral += produto.Preco;
                }

                Console.WriteLine("Relatório de Produtos Agrupados por Categoria:\n");

                foreach (var categoria in TotalPreco.Keys)
                {
                    Console.WriteLine($"{categoria}");

                    foreach (var produto in ProdutosEmpresa.Where(p => p.Categoria == categoria))
                    {
                        Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Preço: {produto.Preco:F2}");
                    }

                    Console.WriteLine($"Subtotal: R${TotalPreco[categoria]:F2}\n");
                }

                Console.WriteLine($"Total Geral dos Preços dos Produtos: R${totalGeral:F2}");
            }
        }
    }
}
