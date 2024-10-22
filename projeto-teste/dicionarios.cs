using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class dicionarios
    {
        public static void testandoDicionarios()
        {
            Dictionary<int, Cliente> dicionarioTeste = new Dictionary<int, Cliente>();

            dicionarioTeste.Add(1, new Cliente() { id = 10, nome = "José"});
            dicionarioTeste.Add(2, new Cliente() { id = 21, nome = "João" });
            dicionarioTeste.Add(3, new Cliente() { id = 12, nome = "Manoel" });

            dicionarioTeste.Remove(2);

            foreach (var item in dicionarioTeste)
            {
                Console.WriteLine($"Elemento: {item.Key}, id: {item.Value.id}, nome: {item.Value.nome}");
            }

            Console.ReadKey();
        }
    }

    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
    }
}
