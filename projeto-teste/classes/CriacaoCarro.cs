using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto.classes;

namespace projeto
{
    public class CriacaoCarro
    {
        public static void CriarCarro()
        {
            Carro carro = new Carro("Nissan", "GTR")
            {
                //Marca = "VW",
                //Modelo = "1969",
                Cor = "Azul",
                PrecoAluguel = 3000
            };

            Console.WriteLine($"Meu primeiro carro da frota é da marca: {carro.Marca} e do modelo {carro.Modelo}");

            Console.Write("Quer alugar esse carro (coloque 'sim' ou 'não'): ");
            string alugar = Console.ReadLine().ToLower();

            if (alugar == "sim")
                carro.Alugar();
            else
                Console.WriteLine("O carro não foi alugado");

            Console.WriteLine($"O {carro.Marca} está alugado? {carro.EstadoAluguel()}");

            Console.ReadKey();
        }
    }
}
