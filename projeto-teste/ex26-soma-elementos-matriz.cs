using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex26_soma_elementos_matriz
    {
        public static int[] TamanhoMatriz()
        {
            while (true)
            {
                int[] matrizNumeros = new int[0];
                try
                {
                    Console.Write("Insira o tamanho da matriz: ");
                    int tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                    matrizNumeros = new int[tamanhoMatriz];

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número válido!");
                }
            }
        }

        public static int[] ElementosMatriz(int[] matrizNumeros)
        {
            while (true)
            {
                try
                {
                    string[] numerosInseridos = new string[matrizNumeros.Length];
                    Console.WriteLine();
                    Console.WriteLine("Insira os elementos: ");
                    for (int i = 0; i < matrizNumeros.Length; i++)
                    {
                        Console.Write($"Elemento {i}: ");
                        string numeros = Console.ReadLine();
                        numerosInseridos[i] = numeros;
                    }

                    for (int i = 0; i < numerosInseridos.Length; i++)
                    {
                        matrizNumeros[i] = int.Parse(numerosInseridos[i]);
                    }

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número válido!");
                }
            }
        }

        public static int SomarElementosMatriz(int[] matrizNumeros)
        {
            int somaElementos = 0;

            for (int i = 0; i < matrizNumeros.Length; i++)
            {
                somaElementos += matrizNumeros[i];
            }

            Console.WriteLine($"A soma de todos os elementos da matriz é {somaElementos}");
            Console.ReadKey();

            return somaElementos;
        }
    }
}
