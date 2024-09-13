using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex16_girar_array
    {
        public static void RotacionarArray()
        {
            Console.Write("Insira os números ou palavras para entrar no array (separados por vírgulas): ");
            string[] elemento = Console.ReadLine().Split(',')
                                                  .Select(e => e.Trim())
                                                  .ToArray();

            string[] arrayRotacionado = new string[elemento.Length];
            arrayRotacionado = elemento.Skip(1).Concat(elemento.Take(1)).ToArray();

            Console.WriteLine();
            Console.WriteLine($"O array original era " + String.Join(", ", elemento) + " e agora rotacionado " +
                String.Join(", ", arrayRotacionado) + "");
            Console.ReadKey();
        }
    }
}
