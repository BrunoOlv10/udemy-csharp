using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex25_elementos_array
    {
        public static void ExibirElementosArray()
        {
            Console.Write("Digite os elementos que entrarão no array (separados por vírgulas): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar vazio");
                Console.ReadKey();
                return;
            }

            string[] elementos = entrada.Split(',').Select(e => e.Trim()).ToArray();

            Console.WriteLine();
            Console.WriteLine("Os elementos dentro do array são: ");
            Console.WriteLine("" + String.Join(", ", elementos) + "");
            Console.ReadKey();
        }
    }
}
