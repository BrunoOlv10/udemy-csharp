using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex5_remover_caractere_especifico
    {
        public static void RemoverCaractereEspecifico()
        {
            Console.Write("Insira os elementos que entrarão no array (separados por vírgula): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar vazio");
                Console.ReadKey();
                return;
            }

            string[] entradaDividida = entrada.Split(',');

            string[] array = entradaDividida.Select(e => e.Trim()).ToArray();

            Console.Write("Qual elemento deseja remover no array? ");
            string remover = Console.ReadLine();

            int contador = array.Count(c => c == remover);

            if (contador > 0)
            {
                string[] arrayAtualizado = array.Where(e => e != remover).ToArray();
                Console.WriteLine();
                Console.WriteLine($"Após remover o elemento '{remover}', em {contador} ocorrência(s) encontradas, o array ficou assim: " + String.Join(", ", arrayAtualizado) + "");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"O elemento '{remover}' não foi encontrado no array");
                Console.ReadKey();
                return;
            }

        }
    }
}
