using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs2
{
    public class ex5_remover_caractere_especifico
    {
        public static void RemoverCaractere()
        {
            try
            {
                Console.Write("Digite uma palavra ou número ou string: ");
                string palavra = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o número da posição da letra que será removida: ");
                int posicaoRemovida = Convert.ToInt32(Console.ReadLine());

                string palavraNova = null;
                if (posicaoRemovida >= 0 && posicaoRemovida <= palavra.Length)
                {
                    palavraNova = palavra.Remove(posicaoRemovida, 1);
                    Console.WriteLine($"A letra da posição {posicaoRemovida} da palavra '{palavra}' foi removida e a palavra ficou '{palavraNova}'");
                }

                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para a posição!");
                Console.ReadKey();
            }
        }
    }
}
