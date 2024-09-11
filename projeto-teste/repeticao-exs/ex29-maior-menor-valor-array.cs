using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex29_maior_menor_valor_array
    {
        public static int[] ObterArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira os números que farão parte do array (separados por vírgulas): ");
                    string numerosString = Console.ReadLine();
                    string[] numerosDivididos = numerosString.Split(',');
                    int[] numerosArray = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numerosArray[i] = int.Parse(numerosDivididos[i]);
                    }

                    return numerosArray;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números para o array!");
                }
            }
        }

        public static (int, int) MaiorMenorValor(int[] numerosArray)
        {
            int maiorNumero = numerosArray[0], menorNumero = numerosArray[0];

            foreach (var numero in numerosArray)
            {
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }

                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }

            Console.WriteLine($"O maior valor do array [" + String.Join(",", numerosArray) + $"] é {maiorNumero} e o menor é {menorNumero}");
            Console.ReadKey();

            return (maiorNumero, menorNumero);
        }
    }
}
