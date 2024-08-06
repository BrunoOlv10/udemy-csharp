using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    class ex6_mudar_caractere_posicao
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma palavra: ");
            string palavra = Console.ReadLine();

            char[] caracteres = palavra.ToCharArray();

            char primeiraLetra = caracteres[0];
            char ultimaLetra = caracteres[caracteres.Length - 1];

            caracteres[0] = ultimaLetra;
            caracteres[caracteres.Length - 1] = primeiraLetra;

            string novaPalavra = new string(caracteres);

            Console.WriteLine($"A palavra com a primeira e última letra invertida ficou assim: {novaPalavra}");
            Console.ReadKey();
        }
    }
}
