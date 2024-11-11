using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex29_maior_menor_valor_array
    {
        public static void EncontrarMaiorMenorArray()
        {
            try
            {
                Console.Write("Digite os números que entrarão no array: ");
                string entrada = Console.ReadLine();
                string[] entradaSeparado = entrada.Split(',');
                int[] array = new int[entrada.Length];
                array = entradaSeparado.Select(n => int.Parse(n)).ToArray();

                int maiorValor = 0;
                int menorValor = int.MaxValue;

                foreach (var numero in array)
                {
                    if (numero > maiorValor)
                        maiorValor = numero;

                    if (numero < menorValor)
                        menorValor = numero;
                }

                Console.WriteLine();
                Console.WriteLine("O números inseridos dentro do array são: " + String.Join(", ", array) + "");
                Console.WriteLine($"O maior número desse array é: {maiorValor}");
                Console.WriteLine($"O menor número desse array é: {menorValor}");
                Console.ReadKey();
            }
            catch (System.Exception)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas números");
                Console.ReadKey();
            }
        }
    }
}
