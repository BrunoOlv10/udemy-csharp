using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;

namespace projeto.classes_exercicios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string sobrenome, string cargo)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cargo = cargo;
        }
    }

    public class Empresa
    {
        List<Funcionario> FuncionariosEmpresa = new List<Funcionario>();

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            FuncionariosEmpresa.Add(funcionario);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("Atualmente esses são os funcionários da empresa:");
            foreach (var funcionario in FuncionariosEmpresa)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
                Console.ReadKey();
            }
        }
    }

}
