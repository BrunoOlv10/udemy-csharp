using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex18_palindromo
    {
        public static void IdentificarPalindromos()
        {
            Console.Write("Escreva uma sequência de caracteres, palavras, números, símbolos (separados por vírgulas): ");
            string[] elementos = Console.ReadLine().Split(',').Select(e => e.Trim()).ToArray();

            bool encontrouPalindromos = false;

            foreach (string elemento in elementos)
            {
                if (string.IsNullOrEmpty(elemento))
                {
                    continue;
                }

                string invertido = new string(elemento.Reverse().ToArray());

                if (elemento.Equals(invertido, StringComparison.OrdinalIgnoreCase))
                {
                    if (!encontrouPalindromos)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O(s) palíndromo(s) são: ");
                        encontrouPalindromos = true;
                    }
                    Console.WriteLine($"{elemento} - {invertido}");
                }
            }

            if (!encontrouPalindromos)
            {
                Console.WriteLine("Nenhum palíndromo encontrado.");
            }

            Console.ReadKey();
        }
    }
}
