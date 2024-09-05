using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex30_excluir_valor_array
    {
        public static int ObterTamanhoArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira o tamanho da array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (tamanhoArray > 0)
                    {
                        return tamanhoArray;
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

        public static int[] ObterElementosArray(int tamanhoArray)
        {
            int[] numerosArray = new int[tamanhoArray];

            while (true)
            {
                try
                {
                    string[] numeros = new string[numerosArray.Length];

                    Console.WriteLine($"Insira os {tamanhoArray} elementos da matriz:");
                    for (int i = 0; i < numerosArray.Length; i++)
                    {
                        Console.Write($"Digite o elemento {i}: ");
                        string numero = Console.ReadLine();
                        numeros[i] = numero;
                    }

                    for (int i = 0; i < numerosArray.Length; i++)
                    {
                        numerosArray[i] = int.Parse(numeros[i]);
                    }

                    return numerosArray;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira números válidos!");
                }
            }
        }

        public static int[] ExcluirValorMatriz(int[] numerosArray)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Qual a posição do valor que deseja excluir? ");
                    int posicao = Convert.ToInt32(Console.ReadLine());

                    if (posicao < 0 || posicao >= numerosArray.Length)
                    {
                        throw new Exception();
                    }

                    int numeroExcluido = 0;
                    for (int i = 0; i < numerosArray.Length; i++)
                    {
                        if (posicao == i)
                        {
                            numeroExcluido = numerosArray[i];
                        }
                    }

                    int[] arrayAtualizado = new int [numerosArray.Length - 1];
                    for (int i = 0, j = 0; i < numerosArray.Length; i++)
                    {
                        if (i != posicao)
                        {
                            arrayAtualizado[j++] = numerosArray[i];
                        }
                    }

                    Console.WriteLine();
                    Console.Write($"Após excluir o {numeroExcluido}, o array ficou assim: ");
                    Console.Write(String.Join(", ", arrayAtualizado));
                    Console.ReadKey();

                    return numerosArray;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Escolha uma posição que exista dentro do array!");
                }
            }
        }
    }
}
