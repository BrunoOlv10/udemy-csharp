using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex32_ordenar_inteiros_bubble_sort
    {
        public static void OrdenarInteirosBubbleSort()
        {
            try
            {
                Console.Write("Digite os elementos que entrarão no array (separados por vírgulas): ");
                string[] entrada = Console.ReadLine().Split(',');
                int[] array = entrada.Select(x => int.Parse(x.Trim())).ToArray();
                int[] arrayOriginal = (int[])array.Clone();

                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    bool repetir = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;

                            repetir = true;
                        }
                    }

                    if (!repetir)
                        break;
                }

                Console.WriteLine();
                Console.WriteLine($"Array digitado: " + String.Join(", ", arrayOriginal) + "");
                Console.WriteLine($"Array ordenado com Bubble Sort: " + String.Join(", ", array) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É possível inserir apenas valores numéricos");
                Console.ReadKey();
            }
        }
    }
}
