using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class CriarVenda
    {
        public static void CadastrarVenda(VendaEmpresa vendaEmpresa)
        {
            Console.Write("Quantas vendas serão cadastradas? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Cadastrar a venda {i + 1}");

                Console.Write("Insira o nome do produto vendido: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Insira a descrição do produto: ");
                string descricaoProduto = Console.ReadLine();

                Console.Write("Insira o preço do produto: ");
                double precoProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Insira a quantidade vendidade desse produto: ");
                int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o nome do funcionário que realizou essa venda: ");
                string nomeFuncionarioVendeu = Console.ReadLine();

                Console.Write("Insira a data que a venda foi realizada: ");
                DateTime dataVenda = Convert.ToDateTime(Console.ReadLine());

                Venda venda = new Venda(nomeProduto, descricaoProduto, precoProduto, quantidadeVendida, nomeFuncionarioVendeu, dataVenda);

                vendaEmpresa.AdicionarVenda(venda);

                Console.WriteLine();
            }

            Console.WriteLine("Produtos cadastrados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
