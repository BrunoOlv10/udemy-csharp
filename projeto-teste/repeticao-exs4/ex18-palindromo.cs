using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex18_palindromo
    {
        public static void GerarPalindromo()
        {
            Console.Write("Digite palavras ou sequência de caracteres para verificar se é um palíndromo (separados por vírgula): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada.Trim()))
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para verificar se é palíndromo ou não");
                Console.ReadKey();
                return;
            }

            string[] entradaValidada = entrada.Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrEmpty(e)).ToArray();

            Dictionary<string, (string palavraInvertida, bool palindromo)> verificadorPalindromo = new Dictionary<string, (string, bool)>();

            foreach (string elemento in entradaValidada)
            {
                string invertido = new string(elemento.Reverse().ToArray());
                bool palindromo = false;

                if (elemento == invertido)
                    palindromo = true;

                verificadorPalindromo.Add(elemento, (invertido, palindromo));
            }

            int i = 1;

            Console.WriteLine();
            Console.WriteLine("Abaixo veja quais elementos digitados são palíndromos e quais não são: ");
            foreach (var elemento in verificadorPalindromo)
            {
                Console.WriteLine($"{i} - Palavra Original: {elemento.Key} - Palavra Invertida: {elemento.Value.palavraInvertida} - É Palíndromo: {(elemento.Value.palindromo ? "Sim" : "Não")}");
                i ++;
            }
            Console.ReadKey();
        }
    }
}
