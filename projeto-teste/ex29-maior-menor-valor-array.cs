using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex29_maior_menor_valor_array
    {
        public static int[] ObterTamanhoArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o tamanho do array a ser construída: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());
                    int[] arrayNumeros = new int[tamanhoArray];

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número em formato válido!");
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

                    Console.WriteLine("Insira os elementos: ");
                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        Console.Write($"Insira o elemento {i}: ");
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
                    Console.WriteLine("Insira números em formatos válidos!");
                }
            }
        }

        public static int[] MaiorMenorArray(int[] arrayNumeros)
        {
            int maiorValor = arrayNumeros[0];
            int menorValor = arrayNumeros[0];

            foreach (int numero in arrayNumeros)
            {
                if (numero > maiorValor)
                    maiorValor = numero;
                if (numero < menorValor)
                    menorValor = numero;
            }

            Console.WriteLine($"O maior número do array é {maiorValor} e o menor número do array é {menorValor}");
            Console.ReadKey();

            return arrayNumeros;
        }
    }
}