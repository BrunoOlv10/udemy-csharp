﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class GeradorRelatoriosFuncionarios
    {
        public static void GerarRelatoriosFuncionarios(FuncionarioEmpresa funcionarioEmpresa)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu Gerar Relatórios de Funcionário(s)");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Listar Funcionário(s)");
                    Console.WriteLine("2- Listar Funcionários por Sobrenome");
                    Console.WriteLine("3- Listar Cargos dos Funcionário(s)");
                    Console.WriteLine("4- Voltar");
                    Console.WriteLine("5- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        funcionarioEmpresa.ListarFuncionarios();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 2)
                    {
                        Console.Clear();
                        funcionarioEmpresa.OrdenarSobrenome();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 3)
                    {
                        Console.Clear();
                        funcionarioEmpresa.ListarCargos();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 4)
                        break;

                    else if (opcao == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                    }

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
}
