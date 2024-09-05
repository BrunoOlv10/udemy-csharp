using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex30_excluir_valor_array
    {
        public static (int[], int) ObterArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite quais números farão parte do array (separados por vírgulas): ");
                    string numerosString = Console.ReadLine();
                    string[] numerosDivididos = numerosString.Split(',');
                    int[] arrayNumeros = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        arrayNumeros[i] = int.Parse(numerosDivididos[i]);
                    }

                    Console.WriteLine();
                    Console.Write("Qual a posição do número deseja excluir? ");
                    int posicaoExcluida = Convert.ToInt32(Console.ReadLine());

                    return (arrayNumeros, posicaoExcluida);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas valores para o array e a posição a ser excluída!");
                }
            }
        }

        public static int[] ArrayNovo(int[] arrayNumeros, int posicaoExcluida)
        {
            int[] novoArray = new int[arrayNumeros.Length - 1];
            int j = 0;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (i != posicaoExcluida)
                {
                    novoArray[j] = arrayNumeros[i];
                    j++;
                }
            }

            Console.WriteLine();   
            Console.WriteLine($"O array inicialmente inserido era ["+ String.Join(",", arrayNumeros) +"] " + $", mas após apagar o numero da posição {posicaoExcluida}, o array ficou [" + String.Join(",", novoArray) + "]");
            Console.ReadKey();

            return novoArray;
        }
    }
}
