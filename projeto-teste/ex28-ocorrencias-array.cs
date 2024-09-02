using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace curso_udemy
{
    public class ex28_ocorrencias_array
    {
        public static int[] ObterTamanhoArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho desejado para o array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());
                    int[] arrayNumeros = new int[tamanhoArray];

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número de tamanho válido!");
                }
            }
        }

        public static int[] ObterElementosArray(int[] arrayNumeros)
        {
            Console.WriteLine();

            while (true)
            {
                try
                {
                    string[] numeros = new string[arrayNumeros.Length];

                    Console.WriteLine("Insira os elementos da matriz: ");
                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        Console.Write($"Digite o {i}º elemento: ");
                        string numero = Console.ReadLine();
                        numeros[i] = numero;
                    }

                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        arrayNumeros[i] = int.Parse(numeros[i]);
                    }

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira números válidos!");
                }
            }
        }

        public static Dictionary<int, int> ElementosRepetidos(int[] arrayNumeros)
        {
            Dictionary<int, int> ocorrencias = new Dictionary<int, int>();

            foreach (int numero in arrayNumeros)
            {
                if (ocorrencias.ContainsKey(numero))
                {
                    ocorrencias[numero]++;
                }
                else
                {
                    ocorrencias[numero] = 1;
                }
            }

            Console.WriteLine();
            foreach (var num in ocorrencias)
            {
                Console.WriteLine($"O {num.Key} tem {num.Value} ocorrência(s)");
            }

            Console.ReadKey();

            return ocorrencias;
        }
    }
}
