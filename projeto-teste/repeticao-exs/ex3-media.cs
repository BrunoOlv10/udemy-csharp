using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;

namespace curso_udemy.repeticao_exs
{
    public class ex3_media
    {
        public static int[] ObterNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Escreva quantos números serão digitados: ");
                    int qntd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int[] numeros = new int[qntd];
                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o numero {i}: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    return numeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Insira apenas números!");
                    Console.WriteLine();
                }
            }
        }

        public static int MediaNumeros(int[] numeros)
        {
            int soma = 0;
            int media = 1;
            int qntd = numeros.Length;
            foreach (int numero in numeros)
            {
                soma += numero;
                media = soma/qntd;
            }

            string numerosInseridos = string.Join(", ", numeros);
            Console.WriteLine();
            Console.WriteLine($"A média entre os números {numerosInseridos} é {media}");
            Console.ReadKey();

            return media;
        }
    }
}
