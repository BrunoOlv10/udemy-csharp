using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex17_maior_valor_array
    {
        public static int[] ObterNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira os números que entrarão no array: ");
                    string entrada = Console.ReadLine();
                    string[] numerosDivididos = entrada.Split(',');
                    int[] numerosValidados = new int[numerosDivididos.Length];

                    for (int i = 0; i < numerosDivididos.Length; i++)
                    {
                        numerosValidados[i] = Convert.ToInt32(numerosDivididos[i].Trim());
                    }

                    return numerosValidados;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
            }
}

public static int MaiorNumero(int[] numerosValidados)
        {
            int maiorNumero = 0;

            foreach (int numero in numerosValidados)
            {
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            Console.WriteLine($"No array [ " + String.Join(", ", numerosValidados) + $" ], o maior número é {maiorNumero}");
            Console.ReadKey();

            return maiorNumero;
        }
    }
}
