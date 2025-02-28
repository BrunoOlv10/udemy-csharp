using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios;

namespace projeto.classes_exercicios_2
{
    public class Venda
    {
        public string ProdutoVendido { get; set; }
        public string Categoria { get; set; }
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string DataVenda { get; set; }
        public double ValorTotal { get; set; }
        public double Comissao { get; set; }
        public string VendidoPor { get; set; }

        public Venda(string produtoVendido, string categoria, int id, double preco, int quantidade, string dataVenda, double valorTotal, 
           double comissao, string vendidoPor)
        {
            this.ProdutoVendido = produtoVendido;
            this.Categoria = categoria;
            this.Id = id;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.DataVenda = dataVenda;
            this.ValorTotal = valorTotal;
            this.Comissao = comissao;
            this.VendidoPor = vendidoPor;
        }
    }

    public class VendaEmpresa
    {
        List<Venda> VendasEmpresa = new List<Venda>();
        private ProdutoEmpresa _produtoEmpresa;

        public VendaEmpresa(ProdutoEmpresa produtoEmpresa)
        {
            _produtoEmpresa = produtoEmpresa;
        }

        public (List<Venda>, bool, bool ) AdicionarVendas(Venda venda)
        {
            bool existeId = VendasEmpresa.Any(v => v.Id == venda.Id);

            bool estoqueDisponivel = false;

            if (!existeId)
            {
                estoqueDisponivel = _produtoEmpresa.AtualizarEstoque(venda.ProdutoVendido, venda.Categoria, venda.Preco, venda.Quantidade);

                if (estoqueDisponivel)
                {
                    VendasEmpresa.Add(venda);
                }
            }

            return (VendasEmpresa, existeId, estoqueDisponivel);
        }

        public void ListarVendas()
        {
            if (VendasEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhuma venda cadastrada");
            }

            else
            {
                Console.WriteLine("Vendas: ");
                foreach (var venda in VendasEmpresa)
                {
                    Console.WriteLine($"Id: {venda.Id} - Nome: {venda.ProdutoVendido} - Categoria: {venda.Categoria} " + $"- Preço Unitário: {venda.Preco:F2} " +
                        $"- Valor Total: {venda.ValorTotal:F2} - Comissão: {venda.Comissao} - Quantidade: {venda.Quantidade} - Data Venda: {venda.DataVenda} " +
                        $"- Vendido Por: {venda.VendidoPor}");
                }
            }
        }

        public void ListarVendasComissõesPorFuncionario()
        {
            if (VendasEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhuma venda cadastrada");
            }

            else
            {
                Dictionary<string, double> TotalComissao = new Dictionary<string, double>();
                double totalComissaoGeral = 0;

                foreach (var venda in VendasEmpresa)
                {
                    if (TotalComissao.ContainsKey(venda.VendidoPor))
                    {
                        TotalComissao[venda.VendidoPor] += (venda.Preco * venda.Quantidade) * 0.10;
                    }

                    else
                    {
                        TotalComissao.Add(venda.VendidoPor, (venda.Preco * venda.Quantidade) * 0.10);
                    }

                    totalComissaoGeral += (venda.Preco * venda.Quantidade) * 0.10;
                }

                Console.WriteLine("Relatório de Vendas e Comissões Por Funcionários:\n");

                foreach (var funcionario in TotalComissao.Keys)
                {
                    Console.WriteLine($"{funcionario}");

                    foreach (var venda in VendasEmpresa.Where(v => v.VendidoPor == funcionario))
                    {
                        Console.WriteLine($"Produto Vendido: {venda.ProdutoVendido} - Categoria: {venda.Categoria} - Id da Venda: {venda.Id} - Preço Unitário: {venda.Preco} " +
                            $"- Valor Total: {venda.ValorTotal} - Quantidade Vendida: {venda.Quantidade} - Data: {venda.DataVenda}");
                    }

                    Console.WriteLine($"Comissão Total do Funcionário: R${TotalComissao[funcionario]:F2}\n");
                }

                Console.WriteLine($"Total Geral das Comissões dos Funcionários: R${totalComissaoGeral:F2}");
            }
        }
    }
}
