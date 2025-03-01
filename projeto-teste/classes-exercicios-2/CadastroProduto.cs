using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class CadastroProduto
    {
        public static void AddProduto(ProdutoEmpresa produtoEmpresa)
        {
            while (true)
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
                        while (true)
                        {
                            Console.Clear();
                            bool verificarExisteId = false;
                            bool existeId;
                            bool verificarExisteProduto = true;
                            bool existeProduto;

                            Console.Write("Insira a quantidade de produtos que serão cadastrados: ");
                            int quantidadeGeral = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();
                            Console.WriteLine("Todos os campos são obrigatórios serem preenchidos (Id, Nome, Categoria e Preço)");
                            Console.WriteLine("Tanto o Id como o Preço tem que ser inserido apenas valores maiores que 0");
                            Console.WriteLine("O Id não pode ser igual ao Id de produtos diferentes que já existem, a menos que o produto cadastrado seja igual a algum que exista");
                            Console.WriteLine("Caso o produto cadastrado já exista, o Id anteriormente cadastrado será mantido e irá incrementar a quantidade disponível desse produto ");

                            List<Produto> ProdutosCadastrados = new List<Produto>();

                            for (int i = 0; i < quantidadeGeral; i++)
                            {
                                verificarExisteId = false;
                                verificarExisteProduto = true;

                                Console.WriteLine($"\nProduto {i + 1}");

                                Console.Write($"Insira o Id do produto: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Insira o Nome: ");
                                string nome = Console.ReadLine();
                                string nomeValidado = string.Join(" ", nome.ToLower().Split(' ').Select(n => char.ToUpper(n[0]) + n.Substring(1)));

                                Console.Write("Insira a Categoria: ");
                                string categoria = Console.ReadLine();
                                string categoriaValidado = string.Join(" ", categoria.ToLower().Split(' ').Select(c => char.ToUpper(c[0]) + c.Substring(1)));

                                Console.Write("Insira o Preço: ");
                                double preco = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Insira a quantidade de vezes que esse produto será cadastrado: ");
                                int quantidadeCadastro = Convert.ToInt32(Console.ReadLine());

                                if (id > 0 && !string.IsNullOrWhiteSpace(nomeValidado) && !string.IsNullOrWhiteSpace(categoriaValidado) && preco > 0)
                                {
                                    Produto produto = new Produto(id, nomeValidado, categoriaValidado, preco);
                                    ProdutosCadastrados.Add(produto);
                                    List<Produto> produtosAtualizados;
                                    (produtosAtualizados, existeId, existeProduto, quantidadeCadastro) = produtoEmpresa.AdicionarProdutos(produto, quantidadeCadastro);

                                    if (existeId && !existeProduto)
                                    {
                                        verificarExisteId = true;
                                        verificarExisteProduto = false;
                                        i--;
                                        Console.WriteLine("\nErro: Já existe um produto com esse Id!");
                                        Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar os produtos");
                                        Console.WriteLine();
                                        Console.ReadKey();
                                        Console.Clear();
                                        continue;
                                    }
                                }
                            }

                            if (ProdutosCadastrados.Count == 0)
                            {
                                Console.WriteLine("\nNenhum produto foi cadastrado, pois todos os campos devem ser preenchidos corretamente para considerar o cadastro");
                                Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar os produtos");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }

                            else if (!verificarExisteId || verificarExisteId && verificarExisteProduto)
                            {
                                Console.WriteLine("\nProdutos cadastrados com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                                Console.ReadKey();
                                break;
                            }
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
