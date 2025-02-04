using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class MenuPrincipal
    {
        public static void SelecionarOpcao(FuncionarioEmpresa funcionario)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1- Insira Funcionários");
                    Console.WriteLine("2- Relatório de Funcionários");
                    Console.WriteLine("3- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        AdicionarFuncionario.AddFuncionario(funcionario);
                    }

                    else if (opcao == 2)
                    {
                        Console.Clear();
                        GeradorRelatoriosFuncionarios.GerarRelatoriosFuncionarios(funcionario);
                    }

                    else if (opcao == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opção inexistente, insira alguma das opções que estão disponíveis");
                        Console.ReadKey();
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
