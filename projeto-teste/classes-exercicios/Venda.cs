using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class Venda
    {
        public string NomeProduto { get; set; }
        public string DscricaoProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeVendida { get; set; }
        public string NomeFuncionarioVendeu { get; set; }
        public DateTime DataVenda { get; set; }
        public double ComissaoVenda { get; set; }

        public Venda(string nomeProduto, string descricaoProduto, double precoProduto, int quantidadeVendida, string nomeFuncionarioVendeu, 
            DateTime dataVenda)
        {
            this.NomeProduto = nomeProduto;
            this.DscricaoProduto = descricaoProduto;
            this.PrecoProduto = precoProduto;
            this.NomeFuncionarioVendeu = nomeFuncionarioVendeu;
            this.DataVenda = dataVenda;
            this.QuantidadeVendida = quantidadeVendida;
        }
    }

    public class VendaEmpresa
    {
        List<Venda> VendasEmpresa = new List<Venda>();

        public List<Venda> AdicionarVenda(Venda venda)
        {
            VendasEmpresa.Add(venda);

            return VendasEmpresa;
        }

        public Dictionary<string, Dictionary<string, double>> ComissaoPorProdutoEVendedor()
        {
            Dictionary<string, Dictionary<string, double>> ComissaoPorVendador = new Dictionary<string, Dictionary<string, double>>();

            foreach (var venda in VendasEmpresa)
            {
                if (!ComissaoPorVendador.ContainsKey(venda.NomeFuncionarioVendeu))
                {
                    ComissaoPorVendador[venda.NomeFuncionarioVendeu] = new Dictionary<string, double>();
                }

                if (!ComissaoPorVendador[venda.NomeFuncionarioVendeu].ContainsKey(venda.NomeProduto))
                {
                    ComissaoPorVendador[venda.NomeFuncionarioVendeu][venda.NomeProduto] = 0;
                }

                double comissao = (venda.PrecoProduto * venda.QuantidadeVendida ) * 0.10;

                ComissaoPorVendador[venda.NomeFuncionarioVendeu][venda.NomeProduto] += comissao;
            }

            return ComissaoPorVendador;
        }

        public Dictionary<string, double> TotalComissaoPorVendedor(Dictionary<string, Dictionary<string, double>> comissaoPorVendedor)
        {
            Dictionary<string, double> totalComissaoPorVendedor = new Dictionary<string, double>();

            foreach (var vendedor in comissaoPorVendedor)
            {
                double totalComissao = 0;
                foreach (var produto in vendedor.Value)
                {
                    totalComissao += produto.Value;
                }

                totalComissaoPorVendedor[vendedor.Key] = totalComissao;
            }

            return totalComissaoPorVendedor;
        }

        public void ListarComissoesVendas()
        {
            var comissaoPorProdutoEVendedor = ComissaoPorProdutoEVendedor();
            var totalComissaoPorVendedor = TotalComissaoPorVendedor(comissaoPorProdutoEVendedor);

            foreach (var vendedor in comissaoPorProdutoEVendedor)
            {
                Console.WriteLine($"Vendedor: {vendedor.Key}");
                foreach (var produto in vendedor.Value)
                {
                    Console.WriteLine($"Produto: {produto.Key}, Comissão: {produto.Value}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Total de comissões por vendedor:");
            foreach (var vendedor in totalComissaoPorVendedor)
            {
                Console.WriteLine($"Vendedor: {vendedor.Key}, Total de Comissão: {vendedor.Value}");
            }
        }

        public void ListarVendas()
        {
            Console.WriteLine();
            Console.WriteLine("Essas foram as vendas realizadas: ");
            foreach (var venda in VendasEmpresa)
            {
                Console.WriteLine($"Nome do produto: {venda.NomeProduto} - Descricao: {venda.DscricaoProduto} - Preco: {venda.PrecoProduto} - Nome do funcionário que vendeu: {venda.NomeFuncionarioVendeu} - " +
                    $"Data da venda: {venda.DataVenda} - Quantidade vendida: {venda.QuantidadeVendida}");
            }
        }

        public Dictionary<string, List<Venda>> VendasPorFuncionario()
        {
            Dictionary<string, List<Venda>> VendasPorFuncionario = new Dictionary<string, List<Venda>>();

            foreach (var venda in VendasEmpresa)
            {
                if (!VendasPorFuncionario.ContainsKey(venda.NomeFuncionarioVendeu))
                {
                    VendasPorFuncionario[venda.NomeFuncionarioVendeu] = new List<Venda>();
                }

                VendasPorFuncionario[venda.NomeFuncionarioVendeu].Add(venda);
            }

            return VendasPorFuncionario;
        }
    }
}
