using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex16_girar_array
    {
        public static void GirarArray()
        {
            Console.Write("Digite palavras, números ou sequências de caracteres (separe cada um por vírgula): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada.Trim()))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar vazio");
                Console.ReadKey();
                return;
            }

            string[] entradaDividida = entrada.Split(',').Select(e => e.Trim()).ToArray();

            string[] entradaTransformada = entradaDividida.Skip(1).Concat(entradaDividida.Take(1)).ToArray();

            Console.WriteLine();
            Console.WriteLine($"O array digitado foi: " + String.Join(", ", entradaDividida) + "");
            Console.WriteLine($"Girando esse array ficou: " + String.Join(", ", entradaTransformada) + "");
            Console.ReadKey();
        }
    }
}
