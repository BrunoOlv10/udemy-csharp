using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex17_maior_valor_array
    {
        public static void MaiorMenorArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgula): ");
                string entrada = Console.ReadLine();
                int[] numeros = entrada.Split(',').Select(e => int.Parse(e.Trim())).ToArray();

                int menor = int.MaxValue;
                int maior = 0;

                foreach (int numero in numeros)
                {
                    if (numero < menor)
                        menor = numero;

                    if (numero > maior)
                        maior = numero;
                }

                Console.WriteLine();
                Console.WriteLine($"Os números dentro do array são: " + String.Join(", ", numeros) + "");
                Console.WriteLine($"O menor número é: {menor}");
                Console.WriteLine($"O maior número é: {maior}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir APENAS números");
                Console.ReadKey();
            }
        }
    }
}
