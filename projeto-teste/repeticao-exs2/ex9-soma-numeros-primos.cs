using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex9_soma_numeros_primos
    {
        public static void SomarPrimos()
        {
            try
            {
                Console.Write("Qual é o limite de quantidade de primos para ser procurado? ");
                int limitePrimos = Convert.ToInt32(Console.ReadLine());

                int encontrados = 0;
                int somaPrimos = 0;
                int numeroAtual = 2;

                while (encontrados < limitePrimos)
                {
                    int numerosDivisiveis = 0;

                    for (int i = 1; i <= numeroAtual; i++)
                    {
                        if (numeroAtual % i == 0)
                        {
                            numerosDivisiveis += 1;
                        }
                    }

                    if (numerosDivisiveis == 2)
                    {
                        encontrados += 1;
                        somaPrimos += numeroAtual;
                    }

                    numeroAtual++;
                }

                Console.WriteLine();
                Console.WriteLine($"A soma dos primeiros {limitePrimos} números primos é {somaPrimos}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para o limite!");
                Console.ReadKey();
            }
        }
    }
}
