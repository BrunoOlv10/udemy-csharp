using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace projeto.classes_exercicios
{
    public class Menu_Principal
    {
        public static void SelecionarMenu(Empresa empresa)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1- Insira um funcionário novo");
                    Console.WriteLine("2- Relatório de funcionários");
                    Console.WriteLine("3- Sair do sistema");
                    Console.Write("Insira o número de opção de menu: ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao != 1 && opcao != 2 && opcao != 3)
                        throw new Exception();

                    if (opcao == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu opção 1");
                        CriarFuncionario.CadastrarNovoFuncionario(empresa);
                        Console.ReadKey();
                    }

                    else if (opcao == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu opção 2");
                        RelatorioFuncionarios.ObterRelatorioFuncionarios(empresa);
                        Console.ReadKey();
                    }

                    else if (opcao == 3)
                    {
                        Console.WriteLine("Saindo do sistema...");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira uma das 3 opções de menu disponíveis!");
                    Console.ReadKey();
                }
            }
        }
    }
}
