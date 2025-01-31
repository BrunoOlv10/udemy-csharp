using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios_2
{
    public class Funcionario
    {
        public string Nome {  get; set; }
        public string Sobrenome {  get; set; }
        public string Cargo {  get; set; }

        public Funcionario(string nome, string sobrenome, string cargo)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cargo = cargo;
        }

        }
    public class FuncionarioEmpresa
    {
        List<Funcionario> FuncionariosEmpresa = new List<Funcionario>();

        public List<Funcionario> AdicionarFuncionarios(Funcionario funcionario)
        {
            FuncionariosEmpresa.Add(funcionario);

            return FuncionariosEmpresa;
        }

        public void ListarFuncionarios()
        {
            foreach (var funcionario in FuncionariosEmpresa)
            {
                Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
            }
        }
    }
}
