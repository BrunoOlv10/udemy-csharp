using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex1_trocar_numeros_variaveis
    {
        public static (int, int) ObterNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            return (numero1, numero2);
        }

        public static bool InverterNumeros(int numero1, int numero2)
        {
            int aux = numero1;
            numero1 = numero2;
            numero2 = aux;

            Console.WriteLine();
            Console.WriteLine($"Primeiro número: {numero1}");
            Console.WriteLine($"Segundo número: {numero2}");
            Console.ReadKey();

            return true;
        }
    }
}