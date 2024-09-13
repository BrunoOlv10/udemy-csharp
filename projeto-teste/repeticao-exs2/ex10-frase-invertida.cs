using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex10_frase_invertida
    {
        public static void InverterFrase()
        {
            try
            {
                Console.Write("Insira uma frase: ");
                string frase = Console.ReadLine();
                string[] palavras = frase.Split(' ');

                if (string.IsNullOrWhiteSpace(frase) || frase.All(c => char.IsLetter(c)))
                    throw new Exception();

                string fraseInvertida = String.Join(" ", palavras.Reverse());

                Console.WriteLine();
                Console.WriteLine($"A frase inicial era {frase}, invertendo essa frase fica {fraseInvertida}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas frases com letras (sem símbolos e números) e não mande vazio");
            }
        }
    }
}
