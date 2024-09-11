using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex3_media
    {
        public static void Media()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira os números (separados por vírgula): ");
                    string numeroString = Console.ReadLine();
                    string[] numerosDivididos = numeroString.Split(',');
                    int[] numeros = new int[numerosDivididos.Length];

                    int numeroConvertido = 0;
                    int soma = 0;
                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numeroConvertido = Convert.ToInt32(numerosDivididos[i]);
                        numeros[i] = numeroConvertido;
                        soma += numeroConvertido;
                    }

                    int media = soma / numerosDivididos.Length;

                    Console.WriteLine();
                    Console.WriteLine($"A média entre o(s) número(s) " + String.Join(",", numerosDivididos) + $" resulta em {media}");
                    Console.ReadKey();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Escreva apenas números!");
                }
            }
        }
    }
}
