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
        public int Id { get; set; }
        public string ProdutoVendido { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string VendidoPor { get; set; }

        public Venda(int id, string produtoVendido, string categoria, double preco, int quantidade, string vendidoPor)
        {
            this.Id = id;
            this.ProdutoVendido = produtoVendido;
            this.Categoria = categoria;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.VendidoPor = vendidoPor;
        }
    }

    public class VendaEmpresa
    {
        List<Venda> VendasEmpresa = new List<Venda>();

        public (List<Venda>, bool existe) AdicionarVendas(Venda venda)
        {
            bool existe = VendasEmpresa.Any(v => v.Id == venda.Id);

            if (!existe)
            {
                VendasEmpresa.Add(venda);
            }

            return (VendasEmpresa, existe);
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
