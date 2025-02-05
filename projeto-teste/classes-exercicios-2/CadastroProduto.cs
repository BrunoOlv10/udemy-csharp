using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using projeto.classes_exercicios;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class CadastroProduto
    {
        public static void AddProduto(ProdutoEmpresa produtoEmpresa)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu Cadastrar Produtos");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1- Adicionar Produtos");
                Console.WriteLine("2- Voltar");
                Console.WriteLine("3- Sair do Sistema");
                Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.Write("Insira quantos produtos serão cadastrados: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Todos os campos são obrigatórios serem preenchidos, pois só será considerado os funcionários que tiverem todos os campos preenchidos (Id, Nome, Categoria e Preço)");
                        Console.WriteLine("OBS: Tanto o Id como o Preço tem que ser inserido apenas valores maiores que 0 e o Id e Nome não podem ser iguais de nenhum produto, caso sejam, esse produto em específico não será cadastrado");
                        Console.WriteLine();

                        List<Produto> ProdutosCadastrados = new List<Produto>();

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.Write($"Insira o Id do {i + 1}º produto: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write($"Insira o Nome: ");
                            string nome = Console.ReadLine();

                            Console.Write($"Insira a Categoria: ");
                            string categoria = Console.ReadLine();

                            Console.Write($"Insira o Preço: ");
                            double preco = Convert.ToDouble(Console.ReadLine());

                            if (id > 0 && !string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(categoria) && preco > 0)
                            {
                                Produto produto = new Produto(id, nome, categoria, preco);
                                ProdutosCadastrados.Add(produto);
                                produtoEmpresa.AdicionarProdutos(produto);
                            }

                            Console.WriteLine();
                        }

                        if (ProdutosCadastrados.Count == 0)
                        {
                            Console.WriteLine("Nenhum produto foi cadastrado, pois todos os campos devem ser preenchidos corretamente para considerar o cadastro");
                            Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar os funcionários");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Produtos cadastrados com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                            Console.ReadKey();
                            break;
                        }
                    }
                }

                if (opcao == 2)
                {
                    Console.Clear();
                    AddProduto(produtoEmpresa);
                }

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
                Console.WriteLine("Insira apenas valores numéricos e os que estão disponíveis");
                Console.ReadKey();
            }
        }
    }
}
