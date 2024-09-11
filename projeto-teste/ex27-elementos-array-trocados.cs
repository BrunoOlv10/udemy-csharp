using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ex27_elementos_array_trocados
    {
        public static int[] ObterTamanhoArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho do array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());
                    int[] arrayNumeros = new int[tamanhoArray];

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Coloque um número válido!");
                }
            }
        }

        public static int[] ObterElementosArray(int[] arrayNumeros)
        {
            while (true)
            {
                try
                {
                    string[] numeros = new string[arrayNumeros.Length];

                    Console.WriteLine();
                    Console.WriteLine("Digite os elementos do array: ");

                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        Console.Write($"Digite o elemento {i} do array: ");
                        string numero = Console.ReadLine();
                        numeros[i] = numero;
                    }

                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        arrayNumeros[i] = int.Parse(numeros[i]);
                    }

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Coloque números válidos!");
                }
            }
        }

        public static int[] TransferirArray(int[] arrayNumeros)
        {
            int[] numerosNovos = new int[arrayNumeros.Length];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                numerosNovos[i] = arrayNumeros[i];
            }

            return numerosNovos;
        }

        public static int[] ExibirArrays(int[] arrayNumeros, int[] numerosNovos)
        {
            Console.WriteLine();
            Console.Write("Os elementos da primeira matriz são: ");
            Console.WriteLine(String.Join(",", arrayNumeros));
            Console.Write("Os elementos da segunda matriz são: ");
            Console.WriteLine(String.Join(",", numerosNovos));
            Console.ReadKey();

            return numerosNovos;
        }
    }
}
