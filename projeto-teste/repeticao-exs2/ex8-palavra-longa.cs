using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex8_palavra_longa
    {
        public static void IdentificarMaiorPalavra()
        {
            try
            {
                Console.Write("Escreva uma frase: ");
                string fraseString = Console.ReadLine();

                if (string.IsNullOrEmpty(fraseString) || !fraseString.All(c => char.IsLetter(c)))
                {
                    throw new Exception();
                }

                string[] palavras = fraseString.Split(' ');

                string maiorPalavra = "";
                foreach (string palavra in palavras)
                {
                    if (palavra.Length > maiorPalavra.Length)
                    {
                        maiorPalavra = palavra;
                    }
                }

                Console.WriteLine($"A maior palavra da frase '{fraseString}' é '{maiorPalavra}'");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Escreva apenas palavras!");
                Console.ReadKey();
            }
        }
    }
}
