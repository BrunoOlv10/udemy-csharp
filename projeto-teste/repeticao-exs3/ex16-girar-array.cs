using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.classes.classesAbstratas;

namespace projeto.repeticao_exs3
{
    class PosicaoZeroException : Exception { }

    class LadoErradoException : Exception { }

    public class ex16_girar_array
    {
        public static void GirarMatriz()
        {
            try
            {
                Console.Write("Escreva os números que entrarão na matriz (separados por vírgula): ");
                string entrada = Console.ReadLine();
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();
                int tamanhoArray = numeros.Length;

                Console.WriteLine();

                Console.Write("Quantas posições vai ser girado o array: ");
                int posicao = Convert.ToInt32(Console.ReadLine());

                if (posicao < 1)
                    throw new PosicaoZeroException();

                int posicaoValidada = posicao % tamanhoArray;

                Console.WriteLine();

                Console.Write("Para qual lado quer girar o array (esquerda ou direita)? ");
                string ladoGirar = Console.ReadLine().ToLower();

                Console.WriteLine();

                if (ladoGirar == "esquerda" || ladoGirar == "esquerdo")
                {
                    Array.Reverse(numeros, 0, posicaoValidada);
                    Array.Reverse(numeros, posicaoValidada, tamanhoArray - posicaoValidada);
                    Array.Reverse(numeros);
                    Console.WriteLine("Girando o array para a esquerda: ");
                }
                else if (ladoGirar == "direita" || ladoGirar == "direito")
                {
                    Array.Reverse(numeros, 0, tamanhoArray - posicaoValidada);
                    Array.Reverse(numeros, tamanhoArray - posicaoValidada, posicaoValidada);
                    Array.Reverse(numeros);
                    Console.WriteLine("Girando o array para a direita: ");
                }
                else
                    throw new LadoErradoException();

                Console.WriteLine($"Após girar o array inserido [ {entrada} ], o resultado foi [ " + String.Join(", ", numeros) + " ]");
                Console.ReadKey();
            }
            catch (PosicaoZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível inserir uma posição menor que 1!");
                Console.ReadKey();
            }
            catch (LadoErradoException)
            {
                Console.WriteLine();
                Console.WriteLine("Só é possível girar o array para a esquerda ou direita!");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para as entradas!");
                Console.ReadKey();
            }
        }
    }
}
