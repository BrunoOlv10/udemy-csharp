using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex26_soma_elementos_array
    {
        public static void SomarElementosArray()
        {
            try
            {
                Console.Write("Digite os números que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                int[] numeros = (entrada.Split(',')).Select(n => int.Parse(n)).ToArray();

                int somador = 0;
                foreach (int numero in numeros)
                    somador += numero;

                Console.WriteLine();
                Console.WriteLine("A soma do array [" + String.Join(", ", numeros) + $"] é: {somador}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array");
                Console.ReadKey();
            }
        }
    }
}
