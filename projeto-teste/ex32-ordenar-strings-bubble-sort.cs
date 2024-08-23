using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;

namespace curso_udemy
{
    public class ex32_ordenar_strings_buble_sort
    {
        public static string[] ObterStrings()
        {
            Console.Write("Insira o número de strings a ser digitadas: ");
            int numeroStrings = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[numeroStrings];
            Console.WriteLine();

            for (int i = 0; i < numeroStrings; i++)
            {
                Console.Write($"Digite a string {i}: ");
                strings[i] = Console.ReadLine();
            }

            return strings;
        }

        public static string[] BubbleSort(string[] strings)
        {
            int n = strings.Length;
            bool trocou = false;

            for (int i = 0; i < n - 1; i++)
            {
                trocou = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (string.Compare(strings[j], strings[j + 1]) > 0)
                    {
                        string temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;

                        trocou = true;
                    }
                }
                
                if (!trocou)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine($"Após a classificação, a matriz aparece como: ");
                for (int c = 0; c < n; c++)
                {
                    Console.WriteLine(strings[c]);
                }

                Console.ReadKey();
            }

            return strings;
        }
    }
}
