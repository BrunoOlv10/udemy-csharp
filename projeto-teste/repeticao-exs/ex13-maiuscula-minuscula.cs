using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex13_maiuscula_minuscula
    {
        public static string ObterPalavra()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Se a palavra tiver menos de 4 letras, a palavra ficará em maiúscula, se não ficará em minúscula");
                    Console.Write("Digite uma palavra: ");
                    string palavra = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(palavra) || !palavra.All(c => char.IsLetter(c)))
                    {
                        throw new Exception();
                    }

                    return palavra;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Escreva apenas letras e palavras!");
                }
            }
        }

        public static string PalavraFinal(string palavra)
        {
            string palavraFinal = palavra;

            if (palavra.Length < 4)
            {
                palavraFinal = palavra.ToUpper();
            }
            else if (palavra.Length >= 4)
            {
                palavraFinal = palavra.ToLower();
            }

            Console.WriteLine();
            Console.WriteLine($"A '{palavra}' depois de inserida ficou: {palavraFinal}");
            Console.ReadKey();
            
            return palavra;
        }
    }
}
