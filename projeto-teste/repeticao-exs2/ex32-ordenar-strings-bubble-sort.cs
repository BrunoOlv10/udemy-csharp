using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex32_ordenar_strings_bubble_sort
    {
        public static void OrdenarStringsBubbleSort()
        {
            Console.Write("Insira os números que entrarão no array (separados por vírgula): ");
            string entrada = Console.ReadLine();
            string[] numerosDivididos = entrada.Split(',');
            int[] numeros = numerosDivididos.Select(num => int.Parse(num.Trim())).ToArray();

            int[] numerosOriginal = (int[])numeros.Clone();

            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O array original era [" + String.Join(", ", numerosOriginal) + $"], depois de ordenado ficou [" 
                + String.Join(", ", numeros) + "]");
            Console.ReadKey();
        }
    }
}
