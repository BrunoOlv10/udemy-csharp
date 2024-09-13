using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex11_contem_palavra
    {
        public static void VerificarContemPalavra()
        {
            try
            {
                Console.Write("Escreva uma frase (apenas letras e palavras): ");
                string frase = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(frase) || !frase.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new Exception();

                string[] palavras = frase.Split(' ');

                Console.Write("Qual é a palavra para procurar se está presente na frase anterior? ");
                string palavraBuscada = Console.ReadLine().ToLower();

                string palavraPresente = "Não";
                foreach (string palavra in palavras)
                {
                    if (palavra == palavraBuscada)
                    {
                        palavraPresente = "Sim";
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"A frase digitada foi '{frase}' e a palavra buscada foi '{palavraBuscada}', portanto ela " +
                    $"está presente na frase? {palavraPresente}");
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas letras e palavras!");
                Console.ReadKey();
            }
        }
    }
}
