using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    class ApenasPalavrasException : Exception { }

    public class ex13_maiuscula_minuscula
    {
        public static void EncontrarMaiuscula()
        {
            try
            {
                Console.WriteLine("Regra: se a palavra conter 4 ou menos letras, ela será exibida toda em maiúscula, se não será " +
                        "exibida em minúcula");
                Console.Write("Insira uma frase (apenas palavras e com um de espaço): ");
                string entrada = Console.ReadLine();
                string[] stringDividida = entrada.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (string.IsNullOrEmpty(entrada) || !stringDividida.All(palavra => palavra.All(char.IsLetter)))
                    throw new ApenasPalavrasException();

                string[] novaString = new string[stringDividida.Length];
                for (int i = 0; i < stringDividida.Length; i++)
                {
                    if (stringDividida[i].Length <= 4)
                        novaString[i] = stringDividida[i].ToUpper();

                    else
                        novaString[i] = stringDividida[i].ToLower();
                }

                string fraseOriginal = string.Join(" ", stringDividida);

                string resultado = String.Join(" ", novaString);
                Console.WriteLine();
                Console.WriteLine($"Originalmente a frase era [{fraseOriginal}], após aplicar a regra ficou [{resultado}]");
                Console.ReadKey();
            }
            catch (ApenasPalavrasException ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário digitar apenas palavras!");
                Console.ReadLine();
            }
        }
    }
}
