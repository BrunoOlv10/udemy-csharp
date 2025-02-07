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
            while (true)
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
                                string nomeValidado = string.Join(" ", nome.ToLower().Split(' ').Select(n => char.ToUpper(n[0]) + n.Substring(1)));

                                Console.Write($"Insira o Sobrenome: ");
                                string sobrenome = Console.ReadLine();
                                string sobrenomeValidado = string.Join(" ", sobrenome.ToLower().Split(' ').Select(s => char.ToUpper(s[0]) + s.Substring(1)));

                                Console.Write($"Insira o Cargo que o {i + 1}º funcionário(a) está atualmente: ");
                                string cargo = Console.ReadLine();
                                string cargoValidado = string.Join(" ", cargo.ToLower().Split(' ').Select(c => char.ToUpper(c[0]) + c.Substring(1)));

                                if (!string.IsNullOrWhiteSpace(nomeValidado) && !string.IsNullOrWhiteSpace(sobrenomeValidado) && !string.IsNullOrWhiteSpace(cargoValidado))
                                {
                                    Funcionario funcionario = new Funcionario(nomeValidado, sobrenomeValidado, cargoValidado);
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
                        break;

                    else if (opcao == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERRO: Opção inexistente, insira alguma das opções que estão disponíveis");
                        Console.ReadKey();
                        return;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERRO: Insira apenas valores numéricos e os que estão disponíveis nas opções do menu");
                    Console.ReadKey();
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERRO: Não deixe de preencher nenhum campo");
                    Console.ReadKey();
                }
            }
        }
    }
}
