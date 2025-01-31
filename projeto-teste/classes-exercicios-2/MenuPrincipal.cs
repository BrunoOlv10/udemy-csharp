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
            try
            {
                Console.WriteLine("1- Insira funcionários");
                Console.WriteLine("2- Relatório de funcionários");
                Console.WriteLine("3- Sair do sistema");
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
                    return;

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inexistente, insira alguma das opções que estão disponíveis");
                    Console.ReadKey();
                    return;
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
