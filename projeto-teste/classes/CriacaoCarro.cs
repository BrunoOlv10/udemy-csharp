using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.classes;

namespace curso_udemy
{
    public class CriacaoCarro
    {
        public static void CriarCarro()
        {
            Carro fusca = new Carro()
            {
                Marca = "VW",
                Cor = "Vermelho",
                Modelo = "1969",
                PrecoAluguel = 100
            };

            Console.WriteLine($"Meu primeiro carro da frota é: {fusca.Marca}");

            Console.Write("Quer alugar esse carro (coloque 'sim' ou 'não'): ");
            string alugar = Console.ReadLine().ToLower();

            if (alugar == "sim")
                fusca.Alugar();
            else
                Console.WriteLine("O carro não foi alugado");

            Console.WriteLine($"O {fusca.Marca} está alugado? {fusca.EstadoAluguel()}");

            Console.ReadKey();
        }
    }
}
