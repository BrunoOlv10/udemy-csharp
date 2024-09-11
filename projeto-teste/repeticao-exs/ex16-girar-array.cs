using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex16_girar_array
    {
        public static int[] ObterNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira os números que irão para o array: ");
                    string entrada = Console.ReadLine();
                    string[] numerosDivididos = entrada.Split(',');
                    int[] numerosValidados = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numerosValidados[i] = Convert.ToInt32(numerosDivididos[i].Trim());
                    }

                    return numerosValidados;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
            }
        }

        public static int[] RotacionarMatriz(int[] numerosValidados)
        {
            int[] numerosRotacionado = numerosValidados.Skip(1).Concat(numerosValidados.Take(1)).ToArray();

            Console.WriteLine();
            Console.WriteLine($"O vetor inicial é [" + string.Join(", ", numerosValidados) + "], depois de rotacionado ele ficou: [" + string.Join(", ", numerosRotacionado) + "]");
            Console.ReadKey();

            return numerosRotacionado;
        }
    }
}
