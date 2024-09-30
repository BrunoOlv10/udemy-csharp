using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex8_palavra_longa
    {
        public static void EncontrarPalavraMaisLonga()
        {
            try
            {
                Console.Write("Digite uma frase ou sequência de números ou símbolos (separados por espaços): ");
                string entrada = Console.ReadLine();
                string[] stringDividida = entrada.Split(' ');

                if (string.IsNullOrEmpty(entrada))
                    throw new Exception();

                string maiorString = null;
                int quantidadeString = 0;
                foreach (string stg in stringDividida)
                {
                    if (stg.Length > quantidadeString)
                    {
                        quantidadeString = stg.Length;
                        maiorString = stg;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"A frase inserida foi '{entrada}' e a maior palavra dela é '{maiorString}' contendo {quantidadeString} caracteres");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo, não é possível deixar vazio");
                Console.ReadKey();
            }
        }
    }
}
