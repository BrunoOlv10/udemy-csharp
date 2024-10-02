using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex17_maior_menor_valor_array
    {
        public static void EncontrarMaiorValorArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array: ");
                string entrada = Console.ReadLine();
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

                int maiorNumero = 0;
                int menorNumero = int.MaxValue;
                //foreach (int numero in numeros)
                //{
                //    if (numero > maiorNumero)
                //        maiorNumero = numero;

                //    if (numero < menorNumero)
                //        menorNumero = numero;
                //}

                maiorNumero = numeros.Max();
                menorNumero = numeros.Min();

                Console.WriteLine();
                Console.WriteLine($"O array inserido foi " + String.Join(", ", numeros) + "");
                Console.WriteLine($"Maior número do array: {maiorNumero}");
                Console.WriteLine($"Menor número do array: {menorNumero}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas números!");
                Console.ReadKey();
            }
        }
    }
}
