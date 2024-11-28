using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex10_frase_invertida
    {
        public static void InverterFrase()
        {
            Console.WriteLine("Aviso: Coloque espaços comuns entre os elementos para o sistemas poder identificar cada um");
            Console.Write("Digite uma frase ou sequência de caractere: ");
            string frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível prosseguir vazio, é preciso digitar algo");
                Console.ReadKey();
                return;
            }

            string[] fraseDividida = frase.Split(' ');
            string[] fraseInvertida = fraseDividida.ToArray();
            Array.Reverse(fraseInvertida);

            Console.WriteLine();
            Console.WriteLine($"A frase digitada originalmente: " + String.Join(" ", fraseDividida) + "");
            Console.WriteLine($"A frase invertida: " + String.Join(" ", fraseInvertida) + "");
            Console.ReadKey();
        }
    }
}
