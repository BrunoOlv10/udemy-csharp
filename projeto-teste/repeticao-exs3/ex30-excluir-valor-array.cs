using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Wordprocessing;

namespace projeto.repeticao_exs3
{
    public class ex30_excluir_valor_array
    {
        public static void ExcluirValorArray()
        {
            try
            {
                Console.Write("Digite quais elementos entrarão no array (separados por vírgula): ");
                string entrada = Console.ReadLine();

                if (entrada.Length == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("É necessário digitar algo para ser inserido no array");
                    Console.ReadKey();
                    return;
                }

                string[] arrayOriginal = entrada.Split(',').Select(e => e.Trim()).ToArray();

                Console.Write("Quer fazer a busca por posição ou por elemento? (digite 'p' para posição e 'e' para elemento): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "p" && resposta != "e")
                {
                    Console.WriteLine();
                    Console.WriteLine("Apenas 'p' ou 'e' são válidos para a resposta");
                    Console.ReadKey();
                    return;
                }

                if (resposta == "p")
                {
                    Console.Write("Digite a posição do elemento que será excluído (começando pela posição 0): ");
                    int posicao = Convert.ToInt32(Console.ReadLine());

                    string[] arrayNovo = new string[arrayOriginal.Length - 1];

                    if (posicao >= 0)
                    {
                        for (int i = 0, j = 0; i < arrayOriginal.Length; i++)
                        {
                            if (i != posicao)
                            {
                                arrayNovo[j] = arrayOriginal[i];
                                j++;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("O array digitado foi: " + String.Join(",", arrayOriginal) + "");
                        Console.WriteLine($"Após excluir o elemento da posição {posicao}, o array ficou: " + String.Join(",", arrayNovo) + "");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Apenas posições a partir de 0 são válidas para fazer a busca");
                        Console.ReadKey();
                        return;
                    }
                }

                else if (resposta == "e")
                {
                    Console.Write("Qual elemento será buscado no array? ");
                    string elemento = Console.ReadLine();

                    if (elemento == string.Empty)
                    {
                        Console.WriteLine();
                        Console.WriteLine("É necessário digitar algo para poder realizar a busca");
                        Console.ReadKey();
                        return;
                    }

                    int achados = 0;

                    for (int i = 0; i < arrayOriginal.Length; i++)
                    {
                        if (arrayOriginal[i] == elemento)
                            achados++;
                    }

                    if (achados == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O elemento buscado não foi encontrado");
                        Console.ReadKey();
                        return;
                    }

                    else
                    {
                        string[] arrayNovo = new string[arrayOriginal.Length - achados];

                        for (int i = 0, j = 0; i < arrayOriginal.Length; i++)
                        {
                            if (arrayOriginal[i] != elemento)
                            {
                                arrayNovo[j] = arrayOriginal[i];
                                j++;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("O array original era: " + String.Join(", ", arrayOriginal) + "");
                        Console.WriteLine($"Após ser excluído o elemento '{elemento}', nas {achados} ocorrência(s), o array ficou: " + String.Join(", ", arrayNovo) + "");
                        Console.ReadKey();
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para a posição");
                Console.ReadKey();
            }
        }
    }
}
