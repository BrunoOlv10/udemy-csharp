using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex29_maior_menor_valor_matriz
    {
        public static int[] ObterTamanhoMatriz()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho da matriz a ser construída: ");
                    int tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                    int[] matrizNumeros = new int[tamanhoMatriz];

                    return matrizNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número em formato válido!");
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

                    Console.WriteLine("Insira os elementos: ");
                    for (int i = 0; i < matrizNumeros.Length; i++)
                    {
                        Console.Write($"Insira o elemento {i}: ");
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
                    Console.WriteLine("Insira números em formatos válidos!");
                }
            }
        }

        public static int[] MaiorMenorMatriz(int[] matrizNumeros)
        {
            int maiorValor = matrizNumeros[0];
            int menorValor = matrizNumeros[0];

            foreach (int numero in matrizNumeros)
            {
                if (numero > maiorValor)
                    maiorValor = numero;
                if (numero < menorValor)
                    menorValor = numero;
            }

            Console.WriteLine($"O maior número da matriz é {maiorValor} e o menor número da matriz é {menorValor}");
            Console.ReadKey();

            return matrizNumeros;
        }
    }
}
