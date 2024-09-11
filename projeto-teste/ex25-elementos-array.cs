using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ex25_elementos_array
    {
        public static int[] ObterElementosArray()
        {
            int[] arrayNumeros = new int[0];

            while (true)
            {
                try
                {
                    Console.Write("Escreva os números para compor o array (separados por vírgula): ");
                    string numeros = Console.ReadLine();
                    string[] numerosDivididos = numeros.Split(',');

                    arrayNumeros = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        string numeroAtual = numerosDivididos[i].Trim();

                        if (!int.TryParse(numeroAtual, out arrayNumeros[i]))
                        {
                            throw new System.FormatException();
                        }

                        arrayNumeros[i] = int.Parse(numerosDivididos[i]);
                    }
                    
                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um número válido!");
                }
            }
        }

        public static int[] ExibirNumerosMatriz(int[] arrayNumeros)
        {
            Console.WriteLine();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {arrayNumeros[i]}");
            }
            
            Console.ReadKey();

            return arrayNumeros;
        }
    }
}
