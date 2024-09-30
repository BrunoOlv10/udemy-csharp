using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex11_contem_palavra
    {
        public static void EncontrarPalavra()
        {
            try
            {
                Console.Write("Insira uma frase ou sequência de números ou símbolos: ");
                string entrada = Console.ReadLine();
                string[] stringDividida = entrada.Split(' ');

                if (string.IsNullOrEmpty(entrada))
                    throw new Exception();

                Console.WriteLine();

                Console.Write("Insira a palavra a ser buscada: ");
                string palavraBuscada = Console.ReadLine();

                if (string.IsNullOrEmpty(palavraBuscada))
                    throw new Exception();

                bool palavraEncontrada = false;
                for (int i = 0; i < stringDividida.Length; i++)
                {
                    if (stringDividida[i] == palavraBuscada)
                    {
                        palavraEncontrada = true;
                    }
                }

                Console.WriteLine();
                if (palavraEncontrada == true)
                    Console.WriteLine($"A palavra buscada era '{palavraBuscada}' e foi encontrada na frase '{entrada}'");
                else
                    Console.WriteLine($"A palavra buscada era '{palavraBuscada}' e NÃO foi encontrada na frase {entrada}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para ser buscado!");
                Console.ReadKey();
            }
        }
    }
}
