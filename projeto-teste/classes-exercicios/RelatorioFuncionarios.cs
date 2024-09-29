using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class RelatorioFuncionarios
    {
        public static void ObterRelatorioFuncionarios(Empresa empresa)
        {
            empresa.ListarFuncionariosOrdenadosPorSobrenome();
            Console.WriteLine();

            var funcionariosPorCargo = empresa.ContarFuncionariosPorCargo();
            Console.WriteLine("Total de funcionários por cargo:");
            foreach (var cargo in funcionariosPorCargo)
            {
                Console.WriteLine($"{cargo.Key}: {cargo.Value} funcionário(s)");
            }
            Console.WriteLine();

            int totalFuncionarios = empresa.ObterTotalFuncionarios();
            Console.WriteLine($"Total geral de funcionários: {totalFuncionarios}");
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
