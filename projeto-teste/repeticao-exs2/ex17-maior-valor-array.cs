using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex17_maior_valor_array
    {
        public static void IdentificarMaiorValorArray()
        {
            try
            {
                Console.Write("Escreva os números que entrarão no array (separados por vírgulas): ");
                string[] entrada = Console.ReadLine().Split(',');
                int[] numeros = new int[entrada.Length];

                for (int i = 0; i < entrada.Length; i++)
                {
                    numeros[i] = int.Parse(entrada[i]);
                }

                int maiorValor = 0;
                foreach (int numero in numeros)
                {
                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"O maior valor do array [" + String.Join(", ", numeros) + $"] é: {maiorValor}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas valores para entrar no array!");
                Console.ReadKey();
            }
        }
    }
}
