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
        public static void SelecionarOpcao(FuncionarioEmpresa funcionario, ProdutoEmpresa produto)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu Principal");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Criar Cadastros (Funcionários ou Produtos): ");
                    Console.WriteLine("2- Relatórios");
                    Console.WriteLine("3- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        MenuCadastros.CadastrarInfos(funcionario, produto);
                    }

                    else if (opcao == 2)
                    {
                        ExibeRelatorios.ExibirRelatorios(funcionario, produto);
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
