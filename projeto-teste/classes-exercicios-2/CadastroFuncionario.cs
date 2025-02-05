using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using projeto.classes_exercicios;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class CadastroFuncionario
    {
        public static void AddFuncionario(FuncionarioEmpresa funcionarioEmpresa)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu Cadastrar Funcionários");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1- Adicionar Funcionários");
                Console.WriteLine("2- Voltar");
                Console.WriteLine("3- Sair do Sistema");
                Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.Write("Insira quantos funcionários serão cadastrados: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Todos os campos são obrigatórios serem preenchidos, pois só será considerado os funcionários que tiverem todos os campos preenchidos (Nome, Sobrenome e Cargo)");
                        Console.WriteLine();

                        List<Funcionario> FuncionariosCadastrados = new List<Funcionario>();

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.Write($"Insira o Nome do {i + 1}º funcionário(a): ");
                            string nome = Console.ReadLine();

                            Console.Write($"Insira o Sobrenome: ");
                            string sobrenome = Console.ReadLine();

                            Console.Write($"Insira o Cargo que o {i + 1}º funcionário(a) está atualmente: ");
                            string cargo = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(sobrenome) && !string.IsNullOrWhiteSpace(cargo))
                            {
                                Funcionario funcionario = new Funcionario(nome, sobrenome, cargo);
                                FuncionariosCadastrados.Add(funcionario);
                                funcionarioEmpresa.AdicionarFuncionarios(funcionario);
                            }

                            Console.WriteLine();
                        }

                        if (FuncionariosCadastrados.Count == 0)
                        {
                            Console.WriteLine("Nenhum funcionário foi cadastrado, pois todos os campos devem ser preenchidos corretamente para considerar o cadastro");
                            Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar os funcionários");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Funcionários cadastrados com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                            Console.ReadKey();
                            break;
                        }
                    }
                }

                else if (opcao == 2)
                {
                    Console.Clear();
                    AddFuncionario(funcionarioEmpresa);
                }

                else if (opcao == 3)
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
