using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony;

namespace projeto.repeticao_exs2
{
    public class ex25_elementos_array
    {
        public static void ExibirNumerosArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] array = new int[numerosDivididos.Length];
                array = numerosDivididos.Select(n => int.Parse(n)).ToArray();

                Console.WriteLine();
                Console.WriteLine($"O array com os números inseridos: " + String.Join(", ", array) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para o array!");
                Console.ReadKey();
            }
        }
    }
}
