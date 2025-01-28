using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex32_ordenar_strings_bubble_sort
    {
        public static void OrdenarStringsBubbleSort()
        {
            Console.Write("Digite os elementos que entrarão no array (separados por vírgulas): ");
            string[] array = Console.ReadLine().Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrWhiteSpace(e)).ToArray();
            string[] arrayOriginal = (string[])array.Clone();

            if (array.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para entrar no array");
                Console.ReadKey();
                return;
            }

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool repetir = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(array[j], array[j + 1], StringComparison.CurrentCulture) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        repetir = true;
                    }
                }

                if (!repetir)
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Array digitado: " + String.Join(", ", arrayOriginal) + "");
            Console.WriteLine("Array ordenado com Bubble Sort: " + String.Join(", ", array) + "");
            Console.ReadKey();
        }
    }
}
