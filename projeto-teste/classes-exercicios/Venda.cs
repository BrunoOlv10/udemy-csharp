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
        public string NomeFuncionarioVendeu { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(string nomeProduto, string nomeFuncionarioVendeu, DateTime dataVenda)
        {
            this.NomeProduto = nomeProduto;
            this.NomeFuncionarioVendeu = nomeFuncionarioVendeu;
            this.DataVenda = dataVenda;
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
