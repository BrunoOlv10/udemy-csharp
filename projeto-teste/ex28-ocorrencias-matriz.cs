using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace curso_udemy
{
    public class ex28_ocorrencias_matriz
    {
        public static int[] ObterTamanhoMatriz()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho desejado para a matriz: ");
                    int tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                    int[] matrizNumeros = new int[tamanhoMatriz];

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número de tamanho válido!");
                }
            }
        }

        public static int[] ObterElementosMatriz(int[] matrizNumeros)
        {
            while (true)
            {
                try
                {
                    string[] numeros = new string[matrizNumeros.Length];

                    Console.WriteLine("Insira os elementos da matriz: ");
                    for (int i = 0; i < matrizNumeros.Length; i++)
                    {
                        Console.Write($"Digite o {i}º elemento: ");
                        string numero = Console.ReadLine();
                        numeros[i] = numero;
                    }

                    for (int i = 0; i < matrizNumeros.Length; i++)
                    {
                        matrizNumeros[i] = int.Parse(numeros[i]);
                    }

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira números válidos!");
                }
            }
        }

        public static Dictionary<int, int> ElementosRepetidos(int[] matrizNumeros)
        {
            Dictionary<int, int> ocorrencias = new Dictionary<int, int>();

            foreach (int numero in matrizNumeros)
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
                if (num.Value > 1)
                {
                    Console.WriteLine($"O {num.Key} tem {num.Value} ocorrências");
                }
                else
                {
                    Console.WriteLine($"O {num.Key} tem apenas {num.Value} ocorrência");
                }
            }

            return ocorrencias;
        }
    }
}
