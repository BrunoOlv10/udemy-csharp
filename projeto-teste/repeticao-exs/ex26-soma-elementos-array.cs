using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex26_soma_elementos_matriz
    {
        public static int[] ArrayNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira o tamanho do array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    int[] numeros = new int[tamanhoArray];
                    for (int i = 0; i < tamanhoArray; i++)
                    {
                        Console.Write($"Insira o elemento {i} do array: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        numeros[i] = numero;
                    }

                    return numeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números, tanto para o tamanho do array como para os elementos dele");
                }
            }
        }

        public static int SomarNumeros(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            Console.WriteLine();
            Console.WriteLine($"A soma dos números do array [" + String.Join(", ", numeros) + $"] é {soma}");
            Console.ReadKey();

            return soma;
        }
    }
}
