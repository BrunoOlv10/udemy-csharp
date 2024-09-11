using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex30_excluir_numero_array
    {
        public static (int[], int) ObterInfosArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite os números do array (separados por vírgula): ");
                    string numeroString = Console.ReadLine();
                    string[] numerosDivididos = numeroString.Split(',');
                    int[] numeros = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numeros[i] = Convert.ToInt32(numerosDivididos[i]);
                    }

                    Console.Write("Digite a posição do número que quer excluir do array: ");
                    int posicao = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    return (numeros, posicao);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
            }
        }

        public static void ArrayAlterado(int[] numeros, int posicao)
        {
            int[] arrayNovo = new int[numeros.Length - 1];
            int numeroPosicao = numeros[posicao];

            int j = 0;
            for (int i = 0; i <  numeros.Length; i++)
            {
                if (numeros[i] != numeroPosicao)
                {
                    arrayNovo[j] = numeros[i];
                    j++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O número {numeroPosicao} da posição {posicao} foi apagado!");
            Console.WriteLine($"Antes o array estava [{String.Join(",", numeros)}] , agora está assim [{String.Join(",", arrayNovo)}] ");
            Console.ReadKey();
        }
    }
}
