using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;

namespace projeto.repeticao_exs
{
    public class ex8_palavra_longa
    {
        public static string[] ObterFrase()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira uma frase (sem pontuações): ");
                    string frase = Console.ReadLine();
                    Console.WriteLine();
                    
                    if (string.IsNullOrEmpty(frase) || !frase.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        throw new Exception();
                    }

                    string[] palavras = frase.Split(' ');

                    return palavras;
                }
                catch
                {
                    Console.WriteLine("Digite apenas letras e palavras!");
                }
            }
        }

        public static List<string> MaiorPalavra(string[] frase)
        {
            List<string> maioresPalavras = new List<string>();
            int maiorComprimento = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                var palavraAtual = frase[i];

                if (palavraAtual.Length > maiorComprimento)
                {
                    maioresPalavras.Clear();
                    maioresPalavras.Add(palavraAtual);
                    maiorComprimento = palavraAtual.Length;
                }
                else if (palavraAtual.Length == maiorComprimento)
                {
                    maioresPalavras.Add(palavraAtual);
                }
            }

            string fraseRemontada = string.Join(" ", frase);
            string maioresPalavrasRecuperadas = string.Join(" ", maioresPalavras);
            Console.WriteLine($"A(s) maior palavra(s) da frase(s) '{fraseRemontada}' é: '{maioresPalavrasRecuperadas}'");
            Console.ReadKey();

            return maioresPalavras;
        }
    }
}
