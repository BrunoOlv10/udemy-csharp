using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes_exercicios;
using projeto.classes_exercicios_2;

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
            if (FuncionariosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionário cadastrado");
            }

            else
            {
                Console.WriteLine("Funcionários: ");
                foreach (var funcionario in FuncionariosEmpresa)
                {
                    Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}\n");
                }
            }
        }

        public void OrdenarSobrenome(string ordenacao)
        {
            if (FuncionariosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionário cadastrado");
            }

            else
            {
                if (ordenacao == "asc")
                {
                    FuncionariosEmpresa = FuncionariosEmpresa.OrderBy(f => f.Sobrenome).ToList();
                    ordenacao = "Ascendente";
                }
                
                else if (ordenacao == "desc")
                {
                    FuncionariosEmpresa = FuncionariosEmpresa.OrderByDescending(f => f.Sobrenome).ToList();
                    ordenacao = "Descendente";
                }

                Console.WriteLine($"Sobrenome dos Funcionários ordenados de forma {ordenacao}:");
                foreach (var funcionario in FuncionariosEmpresa)
                {
                    Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}\n");
                }
            }
        }

        public void ListarCargos()
        {
            if (FuncionariosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionário cadastrado");
            }

            else
            {
                Dictionary<string, int> QuantidadeCargos = new Dictionary<string, int>();
                int totalGeral = 0;

                foreach (var funcionario in FuncionariosEmpresa)
                {
                    if (QuantidadeCargos.ContainsKey(funcionario.Cargo))
                    {
                        QuantidadeCargos[funcionario.Cargo]++;
                    }

                    else
                    {
                        QuantidadeCargos.Add(funcionario.Cargo, 1);
                    }

                    totalGeral++;
                }

                Console.WriteLine("Relatório de Funcionários Agrupados por Cargo:\n");

                foreach (var cargo in QuantidadeCargos.Keys)
                {
                    Console.WriteLine($"{cargo}");

                    foreach (var funcionario in FuncionariosEmpresa.Where(f => f.Cargo == cargo))
                    {
                        Console.WriteLine($"{funcionario.Nome} {funcionario.Sobrenome}");
                    }

                    Console.WriteLine($"Subtotal: {QuantidadeCargos[cargo]}\n");
                }
                
                Console.WriteLine($"Total de Cargos Ocupados na Empresa: {totalGeral}");
            }
        }
    }
}
