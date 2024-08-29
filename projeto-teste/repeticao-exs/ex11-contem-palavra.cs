using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex11_contem_palavra
    {
        public static (string[], string) ObterInfos()
        {
            string[] frase;
            string palavraBuscada;
            while (true)
            {
                Console.Write("Digite uma frase (apenas letras e palavras): ");
                string entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada) && entrada.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    frase = entrada.Split(' ');
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas letras e palavras");
                }
            }

            while (true)
            {
                Console.Write("Qual palavra será buscada na frase? ");
                palavraBuscada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(palavraBuscada) || palavraBuscada.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas letras e palavras");
                }
            }
            
            return (frase, palavraBuscada);
        }

        public static bool EncontrarPalavra(string[] frase, string palavraBuscada)
        {
            bool palavraEncontrada = false;
            foreach (var palavra in frase)
            {
                if (palavra == palavraBuscada)
                {
                    palavraEncontrada = true;
                    break;
                }
            }

            string fraseRemontada = string.Join(" ", frase);

            if (palavraEncontrada)
                Console.WriteLine($"A palavra '{palavraBuscada}' está PRESENTE na frase '{fraseRemontada}'");

            else
                Console.WriteLine($"A palavra '{palavraBuscada}' NÃO está presente na frase '{fraseRemontada}'");

            Console.ReadKey();

            return palavraEncontrada;
        }
    }
}
