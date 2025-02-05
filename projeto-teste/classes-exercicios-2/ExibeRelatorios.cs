using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios_2
{
    public class ExibeRelatorios
    {
        public static void ExibirRelatorios(FuncionarioEmpresa funcionario, ProdutoEmpresa produto)
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
                    Console.WriteLine("3- Voltar");
                    Console.WriteLine("4- Sair do Sistema");
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

                    else if (opcao == 3)
                        break;

                    else if (opcao == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas valores numéricos e os que estão disponíveis nas opções do menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
