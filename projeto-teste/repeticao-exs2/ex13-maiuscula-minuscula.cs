using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex13_maiuscula_minuscula
    {
        public static void IdentificarMaiuscula()
        {
            try
            {
                Console.WriteLine("Regra: se a palavra conter 4 ou menos letras, ela será exibida toda em maiúscula, se não será " +
                    "exibida em minúcula");
                Console.Write("Digite uma palavra (apenas letras): ");
                string palavra = Console.ReadLine();

                if (string.IsNullOrEmpty(palavra) || !palavra.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new Exception();

                string palavraAlterada = "";
                if (palavra.Length <= 4)
                    palavraAlterada = palavra.ToUpper();

                else
                    palavraAlterada = palavra.ToLower();

                Console.WriteLine();
                Console.WriteLine($"Seguindo a regra, a palavra inserida foi '{palavra}' e ela ficou dessa forma: '{palavraAlterada}'");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas palavras e letras!");
                Console.ReadKey();
            }
        }
    }
}
