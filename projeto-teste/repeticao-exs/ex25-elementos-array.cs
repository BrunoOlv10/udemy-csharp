using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex25_elementos_array
    {
        public static int[] Numeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira os números para entrar no array (separe por vírgula): ");
                    string entrada = Console.ReadLine();
                    string[] numerosDivididos = entrada.Split(',');
                    int[] numerosValidados = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numerosValidados[i] = Convert.ToInt32(numerosDivididos[i]);
                    }

                    return numerosValidados;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números (separados por vírgula)");
                }
            }
        }

        public static void ExibirNumeros(int[] numerosValidados)
        {
            Console.WriteLine();
            for (int i = 0; i < numerosValidados.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {numerosValidados[i]}");
            }

            Console.ReadKey();
        }
    }
}
