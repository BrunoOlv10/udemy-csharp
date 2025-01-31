using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class AdicionarFuncionario
    {
        public static void AddFuncionario(FuncionarioEmpresa funcionarioEmpresa)
        {
            try
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu Adicionar Funcionários");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1- Adicionar Funcionários");
                Console.WriteLine("2- Voltar para o Menu Principal");
                Console.WriteLine("3- Sair do Sistema");
                Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.Write("Insira quantos funcionários serão adicionados: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Todos os campos são obrigatórios serem preenchidos, só será considerado os funcionários que tiverem os 3 campos preenchidos (nome, sobrenome e cargo)");
                        Console.WriteLine();

                        List<Funcionario> funcionariosAdicionados = new List<Funcionario>();

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.Write($"Insira o nome do {i + 1}º funcionário(a): ");
                            string nome = Console.ReadLine();

                            Console.Write($"Insira o sobrenome do {i + 1}º funcionário(a): ");
                            string sobrenome = Console.ReadLine();

                            Console.Write($"Insira o cargo que o {i + 1}º funcionário(a) está atualmente: ");
                            string cargo = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(sobrenome) && !string.IsNullOrWhiteSpace(cargo))
                            {
                                Funcionario funcionario = new Funcionario(nome, sobrenome, cargo);
                                funcionariosAdicionados.Add(funcionario);
                                funcionarioEmpresa.AdicionarFuncionarios(funcionario);
                            }

                            Console.WriteLine();
                        }

                        if (funcionariosAdicionados.Count == 0)
                        {
                            Console.WriteLine("Todos os campos devem ser preenchidos corretamente para considerar o cadastro dos funcionários");
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
