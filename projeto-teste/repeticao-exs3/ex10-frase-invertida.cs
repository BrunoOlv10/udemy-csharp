using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex10_frase_invertida
    {
        class EntradaVaziaException : Exception { }
        class UmaPalavraException : Exception { }

        public static void InverterFrase()
        {
            try
            {
                Console.Write("Insira uma frase ou sequência de números ou símbolos para ser invertido: ");
                string entrada = Console.ReadLine();
                string[] stringDividida = entrada.Split(' ');

                if (string.IsNullOrEmpty(entrada))
                    throw new EntradaVaziaException();

                if (stringDividida.Length == 1)
                    throw new UmaPalavraException();

                Array.Reverse(stringDividida);

                string stringInvertida = String.Join(" ", stringDividida);

                Console.WriteLine();
                Console.WriteLine($"A string inserida foi '{entrada}' e invertida ficou '{stringInvertida}'");
                Console.ReadKey();
            }
            catch (EntradaVaziaException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para poder fazer a inversão!");
                Console.ReadKey();
            }
            catch (UmaPalavraException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir mais de um elemento para poder inverter com os outros!");
                Console.ReadKey();
            }
        }
    }
}
