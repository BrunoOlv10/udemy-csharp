using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex12_valor_mais_proximo
    {
        public static void IdentificarValorMaisProximo()
        {
            try
            {
                Console.Write("Quantos números serão inseridos? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                int[] numeros = new int[quantidade];

                Console.WriteLine();

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Digite o número {i + 1}: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();

                Console.Write("Insira o número de referência para ver qual dos outros números está mais perto desse: ");
                int referencia = Convert.ToInt32(Console.ReadLine());

                Dictionary<int, List<int>> diferencas = new Dictionary<int, List<int>>();

                foreach (int numero in numeros)
                {
                    int diferenca = Math.Abs(numero - referencia);

                    if (!diferencas.ContainsKey(diferenca))
                    {
                        diferencas[diferenca] = new List<int>();
                    }

                    diferencas[diferenca].Add(numero);
                }

                int menorDiferenca = diferencas.Keys.Min();
                List<int> numerosMaisProximos = diferencas[menorDiferenca].Distinct().ToList();

                Console.WriteLine();
                Console.WriteLine($"O(s) número(s) inserido(s) foram '" + String.Join(", ", numeros) + "'");
                Console.WriteLine($"O(s) número(s) mais próximo(s) da referencia {referencia} é '" + String.Join(", ",
                    numerosMaisProximos) + $"' e a diferença é de {menorDiferenca}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números em todas as entradas!");
                Console.ReadKey();
            }
        }
    }
}
