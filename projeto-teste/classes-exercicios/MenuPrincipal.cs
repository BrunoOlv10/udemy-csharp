using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;

namespace projeto.classes_exercicios
{
    class NumeroMenuInexistenteException : Exception { } 

    public class Menu_Principal
    {
        public static void SelecionarMenu(FuncionarioEmpresa funcionario, ProdutoEmpresa produto, VendaEmpresa venda)
        {
            Console.WriteLine("1- Ir para menu de funcionários");
            Console.WriteLine("2- Ir para menu de produtos");
            Console.WriteLine("3- Ir para menu de vendas");
            Console.WriteLine("4- Sair do sistema");
            Console.Write("Insira o número de opção de menu: ");
            int opcaoInicial = Convert.ToInt32(Console.ReadLine());

            if (opcaoInicial != 1 && opcaoInicial != 2 && opcaoInicial != 3 && opcaoInicial != 4)
                throw new Exception();

            try
            {
                while (true)
                {
                    if (opcaoInicial == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu de Funcionários");
                        Console.WriteLine("1- Cadastrar um funcionário novo");
                        Console.WriteLine("2- Relatório de funcionários");
                        Console.WriteLine("3- Sair do sistema");
                        Console.Write("Insira o número do que deseja fazer: ");
                        int opcaoFuncionario = Convert.ToInt32(Console.ReadLine());

                        if (opcaoFuncionario != 1 && opcaoFuncionario != 2 && opcaoFuncionario != 3)
                            throw new NumeroMenuInexistenteException();

                        if (opcaoFuncionario == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Cadastrar Funcionário");
                            CriarFuncionario.CadastrarNovoFuncionario(funcionario);
                            Console.ReadKey();
                        }

                        else if (opcaoFuncionario == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Obter Relatório de Funcionários");
                            RelatorioFuncionarios.ObterRelatorioFuncionarios(funcionario);
                            Console.ReadKey();
                        }

                        else if (opcaoFuncionario == 3)
                            break;
                    }

                    else if (opcaoInicial == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu de Produtos");
                        Console.WriteLine("1- Cadastrar um produto");
                        Console.WriteLine("2- Alterar preço de produtos por categoria");
                        Console.WriteLine("3- Relatório de produtos");
                        Console.WriteLine("4- Sair do sistema");
                        Console.Write("Insira o número do que deseja fazer: ");
                        int opcaoProduto = Convert.ToInt32(Console.ReadLine());

                        if (opcaoProduto != 1 && opcaoProduto != 2 && opcaoProduto != 3 && opcaoProduto != 4)
                            throw new Exception();

                        if (opcaoProduto == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Cadastrar Produto");
                            CriarProduto.CadastrarProduto(produto);
                            Console.ReadKey();
                        }

                        else if (opcaoProduto == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Alterar Preços Por Categoria de Produtos");
                            CriarProduto.ObterInfosMudarPreco(produto);
                            Console.ReadKey();
                        }

                        else if (opcaoProduto == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Obter Relatório de Produtos");
                            RelatorioProdutos.ObterRelatorioProdutos(produto);
                            Console.ReadKey();
                        }

                        else if (opcaoProduto == 4)
                            break;
                    }

                    else if (opcaoInicial == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu de Vendas");
                        Console.WriteLine("1- Cadastrar vendas");
                        Console.WriteLine("2- Exibir relatório de vendas");
                        Console.WriteLine("3- Sair do sistema");
                        Console.Write("Insira o número do que deseja fazer: ");
                        int opcaoVenda = Convert.ToInt32(Console.ReadLine());

                        if (opcaoVenda != 1 && opcaoVenda != 2 && opcaoVenda != 3)
                            throw new Exception();

                        if (opcaoVenda == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Menu Vender Produto");
                            CriarVenda.CadastrarVenda(venda);
                            Console.ReadKey();
                        }

                        else if (opcaoVenda == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Relatório de Vendas:");
                            RelatorioVendas.ObterRelatorioVendas(venda);
                            Console.ReadKey();
                        }

                        else if (opcaoInicial == 3)
                            break;
                    }

                    else if (opcaoInicial == 4)
                        break;
                }

            }
            catch (NumeroMenuInexistenteException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira um dos números de opções de menu disponíveis!");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira um número válido nas entradas que solicitam algum valor numérico!");
                Console.ReadKey();
            }
        }
    }
}
