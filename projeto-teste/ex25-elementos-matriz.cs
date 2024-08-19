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
            Console.Write("Escreva os números para compor a matriz (separados por vírgula): ");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');

            int[] matrizNumeros = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosDivididos.Length; i++)
            {
                matrizNumeros[i] = int.Parse(numerosDivididos[i].Trim());
            }

            return matrizNumeros;
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
