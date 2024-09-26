using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class CriarFuncionario
    {
        public static void CadastrarNovoFuncionario()
        {
            Console.WriteLine("Cadastrar novo funcionário");
            Console.Write("Insira o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Insira o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Insira o cargo dele(a) na empresa: ");
            string cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, sobrenome, cargo);

            Empresa empresa = new Empresa();
            empresa.AdicionarFuncionario(funcionario);

            empresa.ListarFuncionarios();
        }
    }
}
