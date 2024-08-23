using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex1_trocar_numeros_variaveis
    {
        public static void InverterNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int aux = numero1;
            numero1 = numero2;
            numero2 = aux;

            Console.WriteLine();
            Console.WriteLine($"Primeiro número: {numero1}");
            Console.WriteLine($"Segundo número: {numero2}");
            Console.ReadKey();
        }
    }
}
