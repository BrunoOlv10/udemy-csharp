using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex26_soma_elementos_array
    {
        public static void SomarElementosArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] array = new int[numerosDivididos.Length];
                array = numerosDivididos.Select(n => int.Parse(n)).ToArray();
                
                int soma = 0;
                for (int i = 0; i < array.Length; i++)
                    soma += array[i];

                Console.WriteLine();
                Console.WriteLine($"A soma dos números do array [" + String.Join(", ", array) + $"] resultou em {soma}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array!");
                Console.ReadKey();
            }
        }
    }
}
