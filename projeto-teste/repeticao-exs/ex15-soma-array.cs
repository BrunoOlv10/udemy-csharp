using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex15_soma_array
    {
        public static int[] ObterNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite os números que serão inseridos na array (separe por vírgula): ");
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
                    Console.WriteLine("Insira apenas números e separe por vírgula!");
                }
            }
        }

        public static int SomarNumeros(int[] numerosValidados)
        {
            int resultadoSoma = 0;

            for (int i = 0; i < numerosValidados.Length; i++)
            {
                resultadoSoma += numerosValidados[i];
            }

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma entre os números inseridos é {resultadoSoma}");
            Console.ReadKey();

            return resultadoSoma;
        }
    }
}
