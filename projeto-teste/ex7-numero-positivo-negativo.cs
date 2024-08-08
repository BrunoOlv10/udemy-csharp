using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    class ex7_numero_positivo_negativo
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            if (numero1 > 0 && numero2 < 0 || numero1 < 0 && numero2 > 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}
