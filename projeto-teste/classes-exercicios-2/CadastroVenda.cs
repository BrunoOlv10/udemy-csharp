using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class CadastroVenda
    {
        public static void AddVenda(VendaEmpresa vendaEmpresa)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu Cadastrar Vendas");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Adicionar Vendas");
                    Console.WriteLine("2- Voltar");
                    Console.WriteLine("3- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        bool verificarExiste = false;

                        Console.WriteLine();
                        Console.WriteLine("É possível cadastrar apenas uma venda por vez");
                        Console.WriteLine("OBS: Id não pode ser igual de nenhuma venda, caso seja, essa venda em específico não será cadastrada");
                        Console.WriteLine();

                        List<Venda> VendasCadastradas = new List<Venda>();

                        Console.Write($"Insira o Id da Venda: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"Insira o Nome do Produto: ");
                        string nome = Console.ReadLine();
                        string nomeValidado = string.Join(" ", nome.ToLower().Split(' ').Select(n => char.ToUpper(n[0]) + n.Substring(1)));

                        Console.Write($"Insira a Categoria: ");
                        string categoria = Console.ReadLine();
                        string categoriaValidado = string.Join(" ", categoria.ToLower().Split(' ').Select(c => char.ToUpper(c[0]) + c.Substring(1)));

                        Console.Write($"Insira o Preço: ");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"Insira a Quantidade Vendida: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"Insira o Nome do Funcionário que Vendeu: ");
                        string vendidoPor = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nomeValidado) && !string.IsNullOrWhiteSpace(categoriaValidado) && preco > 0
                            && quantidade > 0 && !string.IsNullOrWhiteSpace(vendidoPor))
                        {
                            Venda venda = new Venda(id, nomeValidado, categoriaValidado, preco, quantidade, vendidoPor);
                            VendasCadastradas.Add(venda);
                            (List<Venda> vendasAtualizadas, bool existe) = vendaEmpresa.AdicionarVendas(venda);

                            if (existe)
                            {
                                verificarExiste = true;
                                Console.WriteLine("\nErro: Já existe uma venda com esse Id!");
                                Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar a venda");
                                Console.ReadKey();
                                continue;
                            }
                        }

                        if (VendasCadastradas.Count == 0)
                        {
                            Console.WriteLine("\nA venda não foi cadastrada, pois todos os campos devem ser preenchidos corretamente para considerar o cadastro");
                            Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar a venda");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }

                        else if (!verificarExiste)
                        {
                            Console.WriteLine("\nVendas cadastradas com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                            Console.ReadKey();
                            continue;
                        }
                    }

                    if (opcao == 2)
                        break;

                    else if (opcao == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERRO: Insira apenas valores numéricos e os que estão disponíveis");
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
