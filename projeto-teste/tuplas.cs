using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class tuplas
    {
        public static void TestandoTupla()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            var resultado = ValidarNome(nome, sobrenome);

            if (resultado.NomeCompleto.Length > 0)
                Console.WriteLine("Nome completo: " + resultado.NomeCompleto);

            else
                Console.WriteLine("Erro: " + resultado.Mensagem);

            Console.ReadKey();
        }

        public static (string NomeCompleto, string Mensagem) ValidarNome(string nome, string sobrenome)
        {
            if (nome.Length == 0 && sobrenome.Length == 0)
                return (string.Empty, "Nome e sobrenome inválidos");

            if (nome.Length == 0)
                return (string.Empty, "Nome inválido");

            if (sobrenome.Length == 0)
                return (string.Empty, "Sobrenome inválido");

            return (nome + " " + sobrenome, string.Empty);
        }
    }
}
