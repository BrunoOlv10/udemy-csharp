using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using projeto.classes;

namespace projeto
{
    public class CriacaoCarro
    {
        public static void CriarCarro()
        {
            Carro carro = new Carro("Nissan", "GTR", 1000, 1234)
            {
                //Marca = "VW",
                //Cor = "Azul",
                //Modelo = "1969",
                //PrecoAluguel = 3000
            };

            Console.Write("Insira o novo preço do aluguel: ");
            var preco = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a senha cadastrada (apenas números): ");
            int senha = Convert.ToInt32(Console.ReadLine());

            carro.MudarPrecoAluguel(senha, preco);

            Console.WriteLine($"Meu primeiro carro da frota é da marca: {carro.Marca} e do modelo {carro.Modelo} e com preço de aluguel {carro.PrecoAluguel}");

            //Console.Write("Quer alugar esse carro (coloque 'sim' ou 'não'): ");
            //string alugar = Console.ReadLine().ToLower();

            //if (alugar == "sim")
            //    carro.Alugar();
            //else
            //    Console.WriteLine("O carro não foi alugado");

            //Console.WriteLine($"O {carro.Marca} está alugado? {carro.EstadoAluguel()}");

            Console.ReadKey();
        }
    }
}
