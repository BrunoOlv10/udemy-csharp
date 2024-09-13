using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace projeto.repeticao_exs2
{
    public class ex12_valor_mais_proximo
    {
        public static void IdentificarValorProximo()
        {
            try
            {
                Console.Write("Quantos números serão inseridos? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                int[] numeros = new int[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Escreva o número {i + 1}: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Qual será o número de referência para identificar qual o número mais próximo dele? ");
                int referencia = Convert.ToInt32(Console.ReadLine());

                int diferenca = int.MaxValue;
                Dictionary<int, List<int>> diferencas = new Dictionary<int, List<int>>();
                foreach (int numero in numeros)
                {
                    if (numero > referencia)
                    {
                        diferenca = numero - referencia;
                        if (!diferencas.ContainsKey(diferenca))
                        {
                            diferencas[diferenca] = new List<int>();
                        }
                    }
                    else
                    {
                        diferenca = referencia - numero;
                        if (!diferencas.ContainsKey(diferenca))
                        {
                            diferencas[diferenca] = new List<int>();
                        }
                    }

                    diferencas[diferenca].Add(numero);
                }

                int menorDiferenca = int.MaxValue;
                foreach (var dif in diferencas.Keys)
                {
                    if (dif < menorDiferenca)
                    {
                        menorDiferenca = dif;
                    }
                }
                List<int> numerosProximos = diferencas[menorDiferenca];

                Console.WriteLine();
                Console.WriteLine($"Os números inseridos foram " + String.Join(", ", numeros) + "");
                Console.WriteLine($"O(s) número(s) de menor diferença para {referencia} é '" + String.Join(", ", numerosProximos) +
                    $"' e a diferença é de {menorDiferenca}");
                Console.ReadKey();

            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números!");
                Console.ReadKey();
            }
        }
    }
}
