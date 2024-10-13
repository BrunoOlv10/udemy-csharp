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
    }
}
