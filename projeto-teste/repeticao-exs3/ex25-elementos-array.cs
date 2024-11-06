using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex25_elementos_array
    {
        public static void ObterElementosArray()
        {
            Console.Write("Insira os elementos que entrarão no array (separados por vírgula): ");
            string entrada = Console.ReadLine().Trim();

            if (entrada.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar vazio em nenhum dos campos");
                Console.ReadKey();
                return;
            }

            string[] entradaDividida = entrada.Split(',');

            Console.WriteLine();
            Console.WriteLine("Os elementos digitados que estão dentro do array são: ");
            Console.WriteLine("" + String.Join(",", entradaDividida) + "");
            Console.ReadKey();
        }
    }
}
