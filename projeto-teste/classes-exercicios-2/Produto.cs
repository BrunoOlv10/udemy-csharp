using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Produto> AdicionarProdutos(Produto produto)
        {
            bool existe = ProdutosEmpresa.Any(p => p.Id == produto.Id || p.Nome == produto.Nome);

            if (!existe)
            {
                ProdutosEmpresa.Add(produto);
            }

            return ProdutosEmpresa;
        }

        public void ListarProdutos()
        {
            if (ProdutosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionário cadastrado");
            }

            else
            {
                Console.WriteLine("Produtos: ");
                foreach (var produto in ProdutosEmpresa)
                {
                    Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço: {produto.Preco}");
                }
            }
        }
    }
}
