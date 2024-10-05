using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class RelatorioProdutos
    {
        public static void ObterRelatorioProdutos(ProdutoEmpresa produto)
        {
            produto.ListarProdutos();
            Console.WriteLine();

            produto.ObterProdutosPorNome();
            Console.WriteLine();
            
            produto.ListarProdutoAgrupadosPorCategoriaComTotais();
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
