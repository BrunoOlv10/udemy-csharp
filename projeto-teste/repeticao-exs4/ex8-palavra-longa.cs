using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex8_palavra_longa
    {
        public static void EncontrarPalavraLonga()
        {
            Console.WriteLine("Palavras juntas, sem espaços, serão consideradas como uma única palavra");
            Console.Write("Escreva uma frase: ");
            string frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar em branco, é necessário digitar alguma palavra ou frase");
                Console.ReadKey();
                return;
            }

            string[] fraseDividida = frase.Split(' ');

            int maiorTamanho = 0;
            string maiorPalavra = ""; 

            foreach (string palavra in fraseDividida)
            {
                if (palavra.Length > maiorTamanho)
                {
                    maiorTamanho = palavra.Length;
                    maiorPalavra = palavra;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"A frase digitada foi '{frase}'");
            Console.WriteLine($"A maior palavra dessa frase é '{maiorPalavra}' com o tamanho de {maiorTamanho} letras");
            Console.ReadKey();
        }
    }
}
