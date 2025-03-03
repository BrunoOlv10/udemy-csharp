using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class CadastroVenda
    {
        public static void AddVenda(VendaEmpresa vendaEmpresa, ProdutoEmpresa produtoEmpresa)
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
                        while (true)
                        {
                            Console.Clear();
                            bool verificarExisteId = false;
                            bool verificarEstoqueDisponivel = false;

                            Console.Write("Insira a quantidade de vendas que serão cadastradas: ");
                            int quantidadeGeral = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nOBS: Id não pode ser igual de nenhuma venda, caso seja, essa venda em específico não será cadastrada");
                            Console.WriteLine("OBS: Caso vc tente vender um produto que não exista nos produtos cadastrados (será verificado nome e categoria), não será" +
                                "cadastrado a venda e virá uma mensagem avisando");

                            List<Venda> VendasCadastradas = new List<Venda>();

                            for (int i = 0; i < quantidadeGeral; i++)
                            {
                                Console.WriteLine($"\nVenda {i + 1}");

                                Console.Write("Insira o Id da Venda: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write($"Insira o Nome do Produto Vendido: ");
                                string nome = Console.ReadLine();
                                string nomeValidado = string.Join(" ", nome.ToLower().Split(' ').Select(n => char.ToUpper(n[0]) + n.Substring(1)));

                                Console.Write($"Insira a Categoria do Produto: ");
                                string categoria = Console.ReadLine();
                                string categoriaValidada = string.Join(" ", categoria.ToLower().Split(' ').Select(c => char.ToUpper(c[0]) + c.Substring(1)));

                                Produto produtoExistente = produtoEmpresa.Produtos.FirstOrDefault(p => p.Nome == nomeValidado && p.Categoria == categoriaValidada);

                                if (produtoExistente == null)
                                {
                                    Console.WriteLine("\nErro: Não existe esse produto no sistema. Por favor, cadastre ele antes de vender o mesmo");
                                    Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                                    Console.ReadKey();
                                    continue;
                                }

                                double preco = produtoEmpresa.ObterPrecoProduto(nomeValidado, categoriaValidada);

                                Console.Write("Insira a Quantidade Vendida: ");
                                int quantidade = Convert.ToInt32(Console.ReadLine());

                                double valorTotal = preco * quantidade;

                                double comissao = (preco * quantidade) * 0.10;

                                Console.Write("Insira a data que a venda foi realizada (siga esse formato DD/MM/YYYY): ");
                                string dataVenda = Console.ReadLine();

                                if (!DateTime.TryParseExact(dataVenda, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataVendaValidada)
                                    || dataVendaValidada > DateTime.Today)
                                {
                                    Console.WriteLine("\nErro: Data inválida! Preencha novamente");
                                    Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                                    Console.ReadKey();
                                    Console.Clear();
                                    i--;
                                    continue;
                                }

                                string dataVendaConvertida = dataVendaValidada.ToString("dd/MM/yyyy");

                                Console.Write("Insira o Nome do Funcionário que Vendeu: ");
                                string vendidoPor = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(nomeValidado) && !string.IsNullOrWhiteSpace(categoriaValidada) && preco > 0
                                    && quantidade > 0 && !string.IsNullOrWhiteSpace(vendidoPor))
                                {
                                    Venda venda = new Venda(nomeValidado, categoriaValidada, id, preco, quantidade, dataVendaConvertida, valorTotal, comissao, vendidoPor);
                                    VendasCadastradas.Add(venda);
                                    (List<Venda> vendasAtualizadas, bool existeId, bool estoqueDisponivel) = vendaEmpresa.AdicionarVendas(venda);

                                    verificarEstoqueDisponivel = estoqueDisponivel;

                                    if (existeId)
                                    {
                                        verificarExisteId = true;
                                        Console.WriteLine("\nErro: Já existe uma venda com esse Id!");
                                        Console.WriteLine("Pressione qualquer tecla para tentar novamente cadastrar a venda");
                                        Console.ReadKey();
                                        continue;
                                    }

                                    if (!verificarEstoqueDisponivel)
                                    {
                                        i--;
                                    }
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

                            else if (!verificarExisteId && verificarEstoqueDisponivel)
                            {
                                Console.WriteLine("\nVendas cadastradas com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para voltar");
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
