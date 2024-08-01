using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    class trocar_numeros_entre_variaveis
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            var aux = 0;
            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

            Console.WriteLine();
            Console.WriteLine($"Número 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}");
            Console.ReadKey();
        }
    }
}
