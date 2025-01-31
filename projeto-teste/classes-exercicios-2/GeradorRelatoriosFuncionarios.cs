using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios_2
{
    public class GeradorRelatoriosFuncionarios
    {
        public static void GerarRelatoriosFuncionarios(FuncionarioEmpresa funcionarioEmpresa)
        {
            try
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu Gerar Relatórios de Funcionário(s)");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1- Listar Funcionários");
                Console.WriteLine("2- Voltar para o Menu Principal");
                Console.WriteLine("3- Sair do Sistema");
                Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    funcionarioEmpresa.ListarFuncionarios();
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                    opcao = 2;
                }

                if (opcao == 2)
                {
                    Console.Clear();
                    MenuPrincipal.SelecionarOpcao(funcionarioEmpresa);
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
