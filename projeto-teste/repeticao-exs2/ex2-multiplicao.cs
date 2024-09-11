using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex2_multiplicao
    {
        public static void Multiplicacao()
        {
            while (true)
            {
                try
                {
                    Console.Write("Escreva os números (separados por vírgula): ");
                    string numeroString = Console.ReadLine();
                    string[] numerosDivididos = numeroString.Split(',');

                    Console.WriteLine();

                    int[] numeros = new int[numerosDivididos.Length];
                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numeros[i] = int.Parse(numerosDivididos[i]);
                    }

                    int multiplicacao = 1;
                    foreach (int num in numeros)
                    {
                        multiplicacao *= num;
                    }

                Console.WriteLine($"A multiplicação entre o(s) número(s) " + String.Join(",", numerosDivididos) + $" resulta em {multiplicacao}");
                Console.ReadKey();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
            }
        }
    }
}
