using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using OfficeOpenXml.ConditionalFormatting.Contracts;

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

    public class FuncionarioEmpresa
    {
        List<Funcionario> FuncionariosEmpresa = new List<Funcionario>();

        public List<Funcionario> AdicionarFuncionario(Funcionario funcionario)
        {
            FuncionariosEmpresa.Add(funcionario);

            return FuncionariosEmpresa;
        }

        public List<Funcionario> ObterRelatorioFuncionariosPorSobrenome()
        {
            return FuncionariosEmpresa
                    .OrderBy(f => f.Sobrenome)
                    .ThenBy(f => f.Nome)
                    .ToList();
        }

        public Dictionary<string, int> ContarFuncionariosPorCargo()
        {
            return FuncionariosEmpresa
                .GroupBy(f => f.Cargo)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public int ObterTotalFuncionarios()
        {
            return FuncionariosEmpresa.Count;
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine();
            Console.WriteLine("Atualmente esses são os funcionários da empresa:");
            foreach (var funcionario in FuncionariosEmpresa)
            {
                Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
            }
        }

        public void ListarFuncionariosOrdenadosPorSobrenome()
        {
            var funcionariosOrdenados = ObterRelatorioFuncionariosPorSobrenome();
            if (funcionariosOrdenados.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado");
            }
            else
            {
                Console.WriteLine("Funcionários da empresa (ordenados por sobrenome):");
                foreach (var funcionario in funcionariosOrdenados)
                {
                    Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
                }
            }
        }
    }

}
