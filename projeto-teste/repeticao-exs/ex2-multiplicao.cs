using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;

namespace curso_udemy.repeticao_exs
{
    public class ex2_multiplicao
    {
        public static int[] ObterNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Quantos números serão inseridos: ");
                    int qntd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int[] numeros = new int[qntd];
                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o {i + 1}º numero: ");
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

        public static int ResultadoMultiplicacao(int[] numeros)
        {
            int produto = 1;

            foreach (int numero in numeros)
            {
                produto *= numero;
            }

            string numerosInseridos = string.Join(", ", numeros);
            Console.WriteLine();
            Console.WriteLine($"A multiplicação entre os números {numerosInseridos} é {produto}");
            Console.ReadKey();

            return produto;
        }
    }
}
