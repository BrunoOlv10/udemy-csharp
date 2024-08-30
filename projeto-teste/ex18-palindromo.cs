using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex18_polindromo
    {
        public static string ObterPalavra()
        {
            Console.WriteLine("Verificar se é um palíndromo (escrito ao contrário fica igual quando escrita normal)");
            Console.Write("Escreva uma palavra, frase ou número: ");
            string palavra = Console.ReadLine();

            return palavra;
        }

        public static bool Palindromo(string palavra)
        {
            string reverso = new string(palavra.Reverse().ToArray());
            return palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase);
        }

        public static bool ExibirResultado(string palavra, bool palindromo)
        {
            if (palindromo)
            {
                Console.WriteLine($"A palavra \"{palavra}\" é um palíndromo");
            }
            else
            {
                Console.WriteLine($"A palavra \"{palavra}\" NÃO é um palíndromo");
            }

            Console.ReadKey();
            return palindromo;
        }
    }
}
