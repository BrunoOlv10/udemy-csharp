using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class RelatorioVendas
    {
        public static void ObterRelatorioVendas(VendaEmpresa venda)
        {
            venda.ListarVendas();
            Console.WriteLine();

            venda.ListarComissoesVendas();
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
