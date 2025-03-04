using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        public List<Produto> Produtos => ProdutosEmpresa;

        Dictionary<(string Nome, string Categoria, double Preco), int> QuantidadeEstoque = new Dictionary<(string, string, double), int>();
        public Dictionary<(string Nome, string Categoria, double Preco), int> QntdEstoque => QuantidadeEstoque;

        public IEnumerable<dynamic> ObterInfosProdutos()
        {
            var listaProdutos = from produto in ProdutosEmpresa
                                join estoque in QuantidadeEstoque
                                on new { produto.Nome, produto.Categoria } equals new { estoque.Key.Nome, estoque.Key.Categoria }
                                into estoqueProduto
                                from estoque in estoqueProduto.DefaultIfEmpty()
                                select new
                                {
                                    produto.Id,
                                    produto.Nome,
                                    produto.Categoria,
                                    produto.Preco,
                                    Quantidade = estoque.Value
                                };

            return listaProdutos;
        }

        public dynamic ObterPrecoProduto(string nome, string categoria)
        {
            var precoProduto = ProdutosEmpresa
                .Where(p => p.Nome == nome && p.Categoria == categoria)
                .Select(p => p.Preco)
                .FirstOrDefault();

            return precoProduto;
        }

        public (List<Produto>, bool, bool, int) AdicionarProdutos(Produto produto, int quantidadeCadastro)
        {
            bool existeId = ProdutosEmpresa.Any(p => p.Id == produto.Id);

            bool existeProduto = ProdutosEmpresa.Any(p => p.Nome == produto.Nome && p.Categoria == produto.Categoria && p.Preco == produto.Preco);

            if (existeId && existeProduto || !existeId && !existeProduto || !existeId && existeProduto)
            {
                if (!existeProduto)
                {
                    ProdutosEmpresa.Add(produto);
                    QntdEstoque[(produto.Nome, produto.Categoria, produto.Preco)] = quantidadeCadastro;
                }
                else
                {
                    QntdEstoque[(produto.Nome, produto.Categoria, produto.Preco)] += quantidadeCadastro;
                }
            }

            return (ProdutosEmpresa, existeId, existeProduto, quantidadeCadastro);
        }

        public bool AtualizarEstoque(string Nome, string Categoria, double Preco, int Quantidade)
        {
            var chave = (Nome, Categoria, Preco);

            bool estoqueDisponivel = false;

            if (QntdEstoque[chave] >= Quantidade)
            {
                QntdEstoque[(Nome, Categoria, Preco)] -= Quantidade;
                Console.WriteLine($"\nEstoque atualizado! {Quantidade} unidade(s) de {Nome} - {Categoria} foram removidos(as) do estoque");
                Console.WriteLine(QntdEstoque[chave] > 0 ? $"Restaram {QntdEstoque[chave]} unidade(s) desse produto no estoque" : $"Não resta mais nenhuma unidade disponível desse produto em estoque");

                estoqueDisponivel = true;
            }

            else if (QntdEstoque[chave] == 0)
            {
                Console.WriteLine($"\nEstoque insuficiente! Nenhuma unidade disponível de {Nome} - {Categoria}");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine($"\nEstoque insuficiente! Apenas {QntdEstoque[chave]} unidade(s) disponívei(s) de {Nome} - {Categoria}");
                Console.ReadKey();
            }

            return estoqueDisponivel;
        }

        public bool AtualizarPreco(string Nome, string Categoria, string sentidoAlteracao, string tipoAlteracao, double NovoPreco)
        {
            bool existeProduto = ProdutosEmpresa.Any(p => p.Nome == Nome && p.Categoria == Categoria);

            if (existeProduto)
            {
                if (tipoAlteracao == "%")
                {
                    if (sentidoAlteracao == "A")
                    {
                        ProdutosEmpresa.Where(p => p.Nome == Nome && p.Categoria == Categoria).ToList().ForEach(p => p.Preco += (p.Preco * NovoPreco)/100);
                    }

                    else if (sentidoAlteracao == "D")
                    {
                        ProdutosEmpresa.Where(p => p.Nome == Nome && p.Categoria == Categoria).ToList().ForEach(p => p.Preco -= (p.Preco * NovoPreco)/100);
                    }
                }

                else if (tipoAlteracao == "V")
                {
                    ProdutosEmpresa.Where(p => p.Nome == Nome && p.Categoria == Categoria).ToList().ForEach(p => p.Preco = NovoPreco);
                }
            }

            return existeProduto;
        }

        public bool AtualizarPrecoCategoria(string Categoria, string sentidoAlteracao, string tipoAlteracao, double NovoPreco)
        {
            bool existeProduto = ProdutosEmpresa.Any(p => p.Categoria == Categoria);

            if (existeProduto)
            {
                if (tipoAlteracao == "%")
                {
                    if (sentidoAlteracao == "A")
                    {
                        ProdutosEmpresa.Where(p => p.Categoria == Categoria).ToList().ForEach(p => p.Preco += (p.Preco * NovoPreco) / 100);
                    }

                    else if (sentidoAlteracao == "D")
                    {
                        ProdutosEmpresa.Where(p => p.Categoria == Categoria).ToList().ForEach(p => p.Preco -= (p.Preco * NovoPreco) / 100);
                    }
                }

                else if (tipoAlteracao == "V")
                {
                    ProdutosEmpresa.Where(p => p.Categoria == Categoria).ToList().ForEach(p => p.Preco = NovoPreco);
                }
            }

            return existeProduto;
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

                var listaProdutos = ObterInfosProdutos();

                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço: {produto.Preco:F2} - " +
                        ((produto.Quantidade == 0) ? "Produto não disponível em estoque" : $"Quantidade Disponível: {produto.Quantidade}"));
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
                var listaProdutos = ObterInfosProdutos();

                if (ordenacao == "asc")
                {
                    listaProdutos = listaProdutos.OrderBy(p => p.Nome).ToList();
                }

                else if (ordenacao == "desc")
                {
                    listaProdutos = listaProdutos.OrderByDescending(p => p.Nome).ToList();
                }

                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço: {produto.Preco:F2} - " +
                        ((produto.Quantidade == 0) ? "Produto não disponível em estoque" : $"Quantidade Disponível: {produto.Quantidade}"));
                }
            }
        }

        //public void ListarProdutosPorCategoria()
        //{
        //    if (ProdutosEmpresa.Count == 0)
        //    {
        //        Console.WriteLine("Não há nenhum produto cadastrado");
        //    }

        //    else
        //    {
        //        Dictionary<string, double> TotalPreco = new Dictionary<string, double>();
        //        double totalPrecoGeral = 0;

        //        var listaProdutos = ObterInfosProdutos();

        //        foreach (var produto in listaProdutos)
        //        {
        //            if (TotalPreco.ContainsKey(produto.Categoria))
        //            {
        //                TotalPreco[produto.Categoria] += (produto.Preco * QntdEstoque[(produto.Nome, produto.Categoria, produto.Preco)]);
        //            }

        //            else
        //            {
        //                TotalPreco.Add(produto.Categoria, (produto.Preco * QntdEstoque[(produto.Nome, produto.Categoria, produto.Preco)]));
        //            }

        //            totalPrecoGeral += (produto.Preco * QntdEstoque[(produto.Nome, produto.Categoria, produto.Preco)]);
        //        }

        //        Console.WriteLine("Relatório de Produtos Agrupados por Categoria:\n");

        //        foreach (var categoria in TotalPreco.Keys)
        //        {
        //            Console.WriteLine($"{categoria}");

        //            foreach (var produto in listaProdutos.Where(p => p.Categoria == categoria))
        //            {
        //                Console.WriteLine($"Id: {produto.Id} - Nome: {produto.Nome} - Preço: {produto.Preco:F2} - " +
        //                    ((produto.Quantidade == 0) ? "Produto não disponível em estoque" : $"Quantidade Disponível: {produto.Quantidade}"));
        //            }

        //            Console.WriteLine($"Preço Total da Categoria: R${TotalPreco[categoria]:F2}\n");
        //        }

        //        Console.WriteLine($"Total Geral dos Preços dos Produtos: R${totalPrecoGeral:F2}");
        //    }
        //}
    }
}
