using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.recuperar_instituicao_ano
{
    public class ex18_polindromo
    {
        public static string ObterPalavra()
        {
            Console.Write("Escreva uma palavra: ");
            return Console.ReadLine();
        }

        public static bool Palindromo(string palavra)
        {
            string reverso = new string(palavra.Reverse().ToArray());
            return palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase);
        }

        public static void ExibirResultado(string palavra, bool palindromo)
        {
            if (palindromo)
            {
                Console.WriteLine($"A palavra \"{palavra}\" é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A palavra \"{palavra}\" NÃO é um palíndromo.");
            }

            Console.ReadKey();
        }
    }
}
