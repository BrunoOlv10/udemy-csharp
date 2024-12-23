using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex11_contem_palavra
    {
        public static void ContemPalavra()
        {
            Console.Write("Digite uma frase ou sequência de caracteres: ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível enviar vazio");
                Console.ReadKey();
                return;
            }

            string[] entradaDividida = entrada.Split();

            Console.Write("Qual elemento você busca? ");
            string elementoBuscado = Console.ReadLine();

            int ocorrencias = 0;
            foreach (string elemento in entradaDividida)
            {
                if (elemento == elementoBuscado)
                    ocorrencias++;
            }

            Console.WriteLine();
            if (ocorrencias > 0)
            {
                Console.WriteLine($"O elemento '{elementoBuscado}' aparece {ocorrencias} vezes na frase digitada");
                Console.WriteLine($"Frase Inserida: {entrada}");
            }

            else
            {
                Console.WriteLine($"O elemento '{elementoBuscado}' não aparece nenhuma vez na frase digitada");
                Console.WriteLine($"Frase Inserida: {entrada}");
            }

            Console.ReadKey();
        }
    }
}
