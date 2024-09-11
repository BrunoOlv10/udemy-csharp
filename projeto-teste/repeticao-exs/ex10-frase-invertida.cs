using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex10_frase_invertida
    {
        public static string InverterFrase()
        {
            while (true)
            {
                try
                {
                    Console.Write("Escreva uma frase: ");
                    string frase = Console.ReadLine();
                    string[] palavras = frase.Split(' ');

                    if (string.IsNullOrEmpty(frase) || !frase.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        throw new Exception();
                    }

                    string fraseRevertida = string.Join(" ", palavras.Reverse());
                    Console.WriteLine();
                    Console.WriteLine($"A frase '{frase}' revertida ficou: {fraseRevertida}");
                    Console.ReadKey();

                    return fraseRevertida;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Escreva apenas palavras e letras na frase!");
                }
            }
        }
    }
}
