using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex27_elementos_trocados_matriz
    {
        public static int[] ObterTamanhoMatriz()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho da matriz: ");
                    int tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                    int[] matrizNumeros = new int[tamanhoMatriz];

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Coloque um número válido!");
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

                    Console.WriteLine();
                    Console.WriteLine("Digite os elementos da matriz: ");

                    for (int i = 0; i < matrizNumeros.Length; i++)
                    {
                        Console.Write($"Digite o elemento {i} da matriz: ");
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
                    Console.WriteLine("Coloque números válidos!");
                }
            }
        }

        public static int[] TransferirMatriz(int[] matrizNumeros)
        {
            int[] numerosNovos = new int[matrizNumeros.Length];

            for (int i = 0; i < matrizNumeros.Length; i++)
            {
                numerosNovos[i] = matrizNumeros[i];
            }

            return numerosNovos;
        }

        public static int[] ExibirMatrizes(int[] matrizNumeros, int[] numerosNovos)
        {
            Console.WriteLine();
            Console.Write("Os elementos da primeira matriz são: ");
            Console.WriteLine(String.Join(",", matrizNumeros));
            Console.Write("Os elementos da segunda matriz são: ");
            Console.WriteLine(String.Join(",", numerosNovos));
            Console.ReadKey();

            return numerosNovos;
        }
    }
}
