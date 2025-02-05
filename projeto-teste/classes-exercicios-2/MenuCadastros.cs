using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios_2;

namespace projeto.classes_exercicios_2
{
    public class MenuCadastros
    {
        public static void CadastrarInfos(FuncionarioEmpresa funcionario, ProdutoEmpresa produto)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Menu de Cadastros");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1- Cadastrar Funcionários");
                    Console.WriteLine("2- Cadastrar Produtos");
                    Console.WriteLine("3- Voltar");
                    Console.WriteLine("4- Sair do Sistema");
                    Console.Write("Insira o número de opção de menu (dentro das opções acima): ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();
                        CadastroFuncionario.AddFuncionario(funcionario);
                    }

                    else if (opcao == 2)
                    {
                        Console.Clear();
                        CadastroProduto.AddProduto(produto);
                    }

                    else if (opcao == 3)
                        break;

                    else if (opcao == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
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
