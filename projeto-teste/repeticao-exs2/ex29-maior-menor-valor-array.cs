using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex29_maior_menor_valor_array
    {
        public static void IdentificarMaiorMenorValorArray()
        {
            try
            {
                Console.Write("Insira os valores que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] numeros = new int[numerosDivididos.Length];
                numeros = numerosDivididos.Select(n => int.Parse(n)).ToArray();

                int menorValor = numeros[0], maiorValor = numeros[0];

                foreach (int numero in numeros)
                {
                    if (numero < menorValor)
                    {
                        menorValor = numero;
                    }

                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"O menor valor é {menorValor} e o maior é {maiorValor} do array [" + String.Join(", ", numeros) + $"]");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array!");
                Console.ReadKey();
            }
        }
    }
}
