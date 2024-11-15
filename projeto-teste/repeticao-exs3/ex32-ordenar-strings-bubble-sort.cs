using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex32_ordenar_strings_bubble_sort
    {
        public static void OrdenarBubbleSort()
        {
            Console.Write("Insira os elementos que vão compor o array (separados por vírgula): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar esse campo vazio");
                Console.ReadKey();
                return;
            }

            string[] array = entrada.Split(',').Select(e => e.Trim()).ToArray();

            string[] arraryOrdenado = (string[])array.Clone();
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arraryOrdenado[j], arraryOrdenado[j + 1]) > 0)
                    {
                        var temp = arraryOrdenado[j];
                        arraryOrdenado[j] = arraryOrdenado[j + 1];
                        arraryOrdenado[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O array original era [" + String.Join(", ", array) + $"], depois de ordenado ficou [" + String.Join(", ", arraryOrdenado) + "]");
            Console.ReadKey();
        }
    }
}
