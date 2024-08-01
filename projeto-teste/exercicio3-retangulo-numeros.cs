using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    class exercicio3_retangulo_numeros
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para formar o retângulo: ");
            char numeroRetangulo = Console.ReadKey().KeyChar;

            Console.WriteLine();

            Console.WriteLine(new string(numeroRetangulo , 3));

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{numeroRetangulo} {numeroRetangulo}");
            }

            Console.WriteLine(new string(numeroRetangulo, 3));

            Console.ReadKey();
        }
    }
}
