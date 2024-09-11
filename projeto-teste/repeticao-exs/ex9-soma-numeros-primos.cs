using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex9_soma_numeros_primos
    {
        public static int ObterLimite()
        {
            while (true)
            {
                try
                {
                    Console.Write("Quantos números primos quer buscar? ");
                    int limite = Convert.ToInt32(Console.ReadLine());

                    return limite;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas a quantidade de números!");
                }
            }
        }

        public static int EncontrarNumerosPrimos(int limite)
        {
            int encontrados = 0;
            int somaPrimos = 0;
            int numeroAtual = 2;

            while (encontrados < limite)
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

            Console.WriteLine($"A soma dos primeiros {limite} números primos é: {somaPrimos}");
            Console.ReadKey();

            return somaPrimos;
        }
    }
}
