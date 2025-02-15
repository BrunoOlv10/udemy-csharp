using System;
using System.Collections.Generic;
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
        public string VendidoPor { get; set; }

        public Venda(string produtoVendido, string categoria, int id, double preco, int quantidade, string vendidoPor)
        {
            this.ProdutoVendido = produtoVendido;
            this.Categoria = categoria;
            this.Id = id;
            this.Preco = preco;
            this.Quantidade = quantidade;
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
                    Console.WriteLine($"Id: {venda.Id} - Nome: {venda.ProdutoVendido} - Categoria: {venda.Categoria} " +
                        $"- Preço: {venda.Preco:F2} - Quantidade: {venda.Quantidade} - Vendido Por: {venda.VendidoPor}");
                }
            }
        }
    }
}
