using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex30_excluir_valor_matriz
    {
        public static int ObterTamanhoMatriz()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira o tamanho da matriz: ");
                    int tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (tamanhoMatriz > 0)
                    {
                        return tamanhoMatriz;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um formato de tamanho válido!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira um tamanho maior que 0");
                }
            }
        }

        public static int[] ObterElementosMatriz(int tamanhoMatriz)
        {
            int[] numerosMatriz = new int[tamanhoMatriz];

            while (true)
            {
                try
                {
                    string[] numeros = new string[numerosMatriz.Length];

                    Console.WriteLine($"Insira os {tamanhoMatriz} elementos da matriz:");
                    for (int i = 0; i < numerosMatriz.Length; i++)
                    {
                        Console.Write($"Digite o elemento {i}: ");
                        string numero = Console.ReadLine();
                        numeros[i] = numero;
                    }

                    for (int i = 0; i < numerosMatriz.Length; i++)
                    {
                        numerosMatriz[i] = int.Parse(numeros[i]);
                    }

                    return numerosMatriz;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira números válidos!");
                }
            }
        }

        public static int[] ExcluirValorMatriz(int[] numerosMatriz)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Qual a posição do valor que deseja excluir? ");
                    int posicao = Convert.ToInt32(Console.ReadLine());

                    if (posicao < 0 || posicao >= numerosMatriz.Length)
                    {
                        throw new Exception();
                    }

                    int numeroExcluido = 0;
                    for (int i = 0; i < numerosMatriz.Length; i++)
                    {
                        if (posicao == i)
                        {
                            numeroExcluido = numerosMatriz[i];
                        }
                    }

                    int[] matrizAtualizada = new int [numerosMatriz.Length - 1];
                    for (int i = 0, j = 0; i < numerosMatriz.Length; i++)
                    {
                        if (i != posicao)
                        {
                            matrizAtualizada[j++] = numerosMatriz[i];
                        }
                    }

                    Console.WriteLine();
                    Console.Write($"Após excluir o {numeroExcluido}, a matriz ficou assim: ");
                    Console.Write(String.Join(", ", matrizAtualizada));
                    Console.ReadKey();

                    return numerosMatriz;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Escolha uma posição que exista dentro da matriz!");
                }
            }
        }
    }
}
