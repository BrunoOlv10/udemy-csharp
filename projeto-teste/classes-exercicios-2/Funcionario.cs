using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
                }
            }
        }

        public void OrdenarSobrenome()
        {
            if (FuncionariosEmpresa.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionário cadastrado");
            }

            else
            {
                List<Funcionario> OrdenacaoSobrenome = new List<Funcionario>();

                FuncionariosEmpresa = FuncionariosEmpresa.OrderBy(x => x.Sobrenome).ToList();

                foreach (var funcionario in FuncionariosEmpresa)
                {
                    Console.WriteLine($"Nome Completo: {funcionario.Nome} {funcionario.Sobrenome} - Cargo: {funcionario.Cargo}");
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

                Console.WriteLine("Cargos:");
                foreach (var cargo in QuantidadeCargos)
                {
                    Console.WriteLine($"{cargo.Key}: {cargo.Value} funcionário(s)");
                }
                Console.WriteLine();
                Console.WriteLine($"Total de cargos ocupados na empresa: {totalGeral}");
            }
        }
    }
}
