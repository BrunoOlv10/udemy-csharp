using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace projeto.classes
{
    public class Carros
    {
        public static void ManipularCarros()
        {
            List<Carro> listaCarros = new List<Carro>()
            {
                new Carro("Honda", "Civic", "Preto", 400),
                new Carro("Fiat", "Stilo", "Azul", 150),
                new Carro("Ford", "Fusion", "Vermelho", 500),
                new Carro("VW", "Jetta", "Cinza", 800),
                new Carro("Nissan", "GTR", "Roxo", 2000),
                new Carro("VW", "Golf", "Branco", 600),
                new Carro("Mercedes", "A200", "Vinho", 1000)
            };

            //var listaFiltrada = from carro in listaCarros
            //                    where carro.PrecoAluguel >= 500 && carro.Marca == "VW" || carro.Marca == "Mercedes"
            //                    select carro;

            //var listaFiltrada = listaCarros.Where(car => car.Marca == "VW" && car.PrecoAluguel > 600);

            Func<Carro, bool> filtroCarroMarca = car => car.Marca == "VW";

            var listaFiltrada = listaCarros.Where(filtroCarroMarca)
                                           .Where(car => car.PrecoAluguel > 600).ToList();

            foreach (var carro in listaFiltrada)
            {
                Console.WriteLine($"Carro marca {carro.Marca} e do modelo {carro.Modelo}");
            }

            Console.ReadKey();
        }
    }
}
