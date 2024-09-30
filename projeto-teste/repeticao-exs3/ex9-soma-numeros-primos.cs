using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex9_soma_numeros_primos
    {
        public static void ObterSomaPrimos()
        {
            try
            {
                Console.Write("Insira o limite de primos a ser buscado: ");
                int limite = Convert.ToInt32(Console.ReadLine());

                int encontrados = 0, somaPrimos = 0, numeroAtual = 2;

                while (encontrados < limite)
                {
                    int numerosDivisiveis = 0;

                    for (int i = 1; i <= numeroAtual; i++)
                    {
                        if (numeroAtual % i == 0)
                        {
                            numerosDivisiveis++;
                        }
                    }

                    if (numerosDivisiveis == 2)
                    {
                        encontrados++;
                        somaPrimos += numeroAtual;
                    }

                    numeroAtual++;
                }

                Console.WriteLine();
                Console.WriteLine($"Foram encontrados os {limite} números primos e a soma entre eles resulta em {somaPrimos}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para o limite!");
                Console.ReadKey();
            }
        }
    }
}
