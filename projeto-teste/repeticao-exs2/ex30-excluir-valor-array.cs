using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex30_excluir_valor_array
    {
        public static void ExcluirValorArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] numeros = new int[numerosDivididos.Length];
                numeros = numerosDivididos.Select(n => int.Parse(n)).ToArray();

                Console.WriteLine();

                Console.Write("Insira a posição do valor que quer excluir: ");
                int posicao = Convert.ToInt32(Console.ReadLine());

                int[] numerosNovos = new int[numeros.Length - 1];
                
                for (int i = 0, j = 0; i < numeros.Length; i++)
                {
                    if (i != posicao)
                    {
                        numerosNovos[j] = numeros[i];
                        j++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"O array original é [" + String.Join(", ", numeros) + $"], após retirar o número da posição {posicao} ficou: " +
                    $"[" + String.Join(", ", numerosNovos) + "]");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira uma posição que exista no array!");
                Console.ReadKey();
            }
        }
    }
}
