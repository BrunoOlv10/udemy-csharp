using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class CriarFuncionario
    {
        public static void CadastrarNovoFuncionario(FuncionarioEmpresa funcionarioEmpresa)
        {
            Console.Write("Quantos funcionários você deseja cadastrar? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Cadastrar o funcionário {i + 1}");

                Console.Write("Insira o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Insira o sobrenome: ");
                string sobrenome = Console.ReadLine();

                Console.Write("Insira o cargo dele(a) na empresa: ");
                string cargo = Console.ReadLine();

                Funcionario funcionario = new Funcionario(nome, sobrenome, cargo);

                funcionarioEmpresa.AdicionarFuncionario(funcionario);

                Console.WriteLine();
            }

            Console.WriteLine("Funcionários cadastrados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
