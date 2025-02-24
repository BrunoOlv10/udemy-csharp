using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios_2
{
    public class GeradorRelatoriosVendas
    {
        public static void GerarRelatoriosVendas(VendaEmpresa vendaEmpresa)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu Gerar Relatórios de Venda(s)");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Listar Vendas");
                    Console.WriteLine("2- Listar Vendas e Comissões Por Funcionário");
                    Console.WriteLine("3- Voltar");
                    Console.WriteLine("4- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        vendaEmpresa.ListarVendas();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 2)
                    {
                        Console.Clear();
                        vendaEmpresa.ListarVendasComissõesPorFuncionario();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
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
                    Console.WriteLine("ERRO: Insira apenas valores numéricos e os que estão disponíveis nas opções do menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
