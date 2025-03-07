using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios_2
{
    public class ExibeRelatorios
    {
        public static void ExibirRelatorios(FuncionarioEmpresa funcionario, ProdutoEmpresa produto, VendaEmpresa venda)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu de Relatórios");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Menu Relatório de Funcionários");
                    Console.WriteLine("2- Menu Relatório de Produtos");
                    Console.WriteLine("3- Menu Relatório de Vendas");
                    Console.WriteLine("4- Voltar");
                    Console.WriteLine("5- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        GeradorRelatoriosFuncionarios.GerarRelatoriosFuncionarios(funcionario);
                    }

                    if (opcao == 2)
                    {
                        Console.Clear();
                        GeradorRelatoriosProdutos.GerarRelatoriosFuncionarios(produto);
                    }

                    if (opcao == 3)
                    {
                        Console.Clear();
                        GeradorRelatoriosVendas.GerarRelatoriosVendas(venda);
                    }

                    else if (opcao == 4)
                        break;

                    else if (opcao == 5)
                    {
                        Console.WriteLine("\nSaindo do sistema...");
                        Environment.Exit(0);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nERRO: Insira apenas valores numéricos e os que estão disponíveis nas opções do menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
