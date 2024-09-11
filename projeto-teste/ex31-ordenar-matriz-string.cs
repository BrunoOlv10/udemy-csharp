using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ex31_ordenar_matriz_string
    {
        public static char[] ObterPalavra()
        {
            string palavra = "";
            bool validoPreenchido = false;
            bool validoPalavra = false;

            while (!validoPreenchido || !validoPalavra)
            {
                Console.Write("Escreva uma palavra (apenas letras): ");
                palavra = Console.ReadLine();

                validoPreenchido = !string.IsNullOrEmpty(palavra);
                if (!validoPreenchido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Entrada inválida. A palavra não pode ser vazia!");
                    continue;
                }

                validoPalavra = true;
                foreach (char c in palavra)
                {
                    if (!char.IsLetter(c))
                    {
                        validoPalavra = false;
                        Console.WriteLine();
                        Console.WriteLine("Entrada inválida! Insira apenas letras.");
                        break;
                    }
                }
            }

            return palavra.ToCharArray();
        }

        public static string OrdenarPalavra(char[] palavraCaracteres)
        {
            string palavraInicial = new string(palavraCaracteres);
            Array.Sort(palavraCaracteres);
            string palavraOrdenada = new string(palavraCaracteres);
            Console.WriteLine();
            Console.Write($"A palavra '{palavraInicial}', ordenada ficou: {palavraOrdenada}");
            Console.ReadKey();

            return palavraOrdenada;
        }
    }
}
