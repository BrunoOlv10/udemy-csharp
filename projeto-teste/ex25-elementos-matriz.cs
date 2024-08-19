using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex25_elementos_matriz
    {
        public static int[] obterElementosMatriz()
        {
            int[] matrizNumeros = new int[0];

            while (true)
            {
                try
                {
                    Console.Write("Escreva os números para compor a matriz (separados por vírgula): ");
                    string numeros = Console.ReadLine();
                    string[] numerosDivididos = numeros.Split(',');

                    matrizNumeros = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        string numeroAtual = numerosDivididos[i].Trim();

                        if (!int.TryParse(numeroAtual, out matrizNumeros[i]))
                        {
                            throw new System.FormatException();
                        }

                        matrizNumeros[i] = int.Parse(numerosDivididos[i]);
                    }
                    
                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um número válido!");
                }
            }
        }

        public static int[] exibirNumerosMatriz(int[] matrizNumeros)
        {
            Console.WriteLine();

            for (int i = 0; i < matrizNumeros.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {matrizNumeros[i]}");
            }
            
            Console.ReadKey();

            return matrizNumeros;
        }
    }
}
