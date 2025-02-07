using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios;

namespace projeto.classes_exercicios_2
{
    public class GeradorRelatoriosProdutos
    {
        public static void GerarRelatoriosFuncionarios(ProdutoEmpresa produtoEmpresa)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu Gerar Relatórios de Produto(s)");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Listar Produto(s)");
                    Console.WriteLine("2- Ordenar Produto(s) por Nome - Ascendente");
                    Console.WriteLine("3- Ordenar Produto(s) por Nome - Descendente");
                    Console.WriteLine("4- Listar Produto(s) por Categoria");
                    Console.WriteLine("5- Voltar");
                    Console.WriteLine("6- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        produtoEmpresa.ListarProdutos();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 2) 
                    {
                        Console.Clear();
                        string ordenacao = "asc";
                        produtoEmpresa.OrdenarNome(ordenacao);
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 3)
                    {
                        Console.Clear();
                        string ordenacao = "desc";
                        produtoEmpresa.OrdenarNome(ordenacao);
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 4)
                    {
                        Console.Clear();
                        produtoEmpresa.ListarCategorias();
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                    }

                    else if (opcao == 5)
                        break;

                    else if (opcao == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERRO: Insira apenas valores numéricos e os que estão disponíveis nas opções do menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
