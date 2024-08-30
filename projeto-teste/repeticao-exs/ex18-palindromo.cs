using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex18_palindromo
    {
        public static (string, string) ObterPalavra()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string reverso = new string(palavra.Reverse().ToArray());

            return (palavra, reverso);
        }

        public static bool VerificarPalindromo(string palavra, string reverso)
        {
            bool palindromo = false;

            if (palavra == reverso)
            {
                palindromo = true;
            }

            Console.WriteLine();
            if (palindromo == true)
                Console.WriteLine($"A palavra '{palavra}' revertida fica '{reverso}', portanto é um palindromo!");

            else
                Console.WriteLine($"A palavra '{palavra}' revertida fica '{reverso}', portanto NÃO é um palindromo!");

            Console.ReadKey();
            return palindromo;
        }
    }
}
