using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex28_ocorrencias_array
    {
        public static int[] ObterInfosArray() 
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho do array: ");
                    int tamanho = Convert.ToInt32(Console.ReadLine());

                    int[] numeros = new int[tamanho];
                    Console.WriteLine();
                    for (int i = 0; i < tamanho; i++)
                    {
                        Console.Write($"Insira o elemento {i}: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        numeros[i] = numero;
                    }

                    return numeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira números válidos para o tamanho do array e quantidade de elementos do mesmo");
                }
            }
        }

        public static void ElementosRepetidos(int[] numeros)
        {
            Dictionary<int, int> ocorrencias = new Dictionary<int, int>();

            foreach (int numero in numeros)
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
                Console.WriteLine($"O {num.Key} tem um total de {num.Value} ocorrências");
            }

            Console.ReadKey();
        }
    }
}
