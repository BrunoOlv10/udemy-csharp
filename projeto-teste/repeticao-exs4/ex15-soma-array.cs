using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex15_soma_array
    {
        public static void SomarArray()
        {
            try
            {
                Console.Write("Digite os números que entrarão no array (separados por vírgula): ");
                string entrada = Console.ReadLine();
                int[] numeros = entrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();

                int somador = 0;
                foreach (int numero in numeros) 
                    somador += numero;

                Console.WriteLine();
                Console.WriteLine($"O array digitado foi: " + String.Join(", ", numeros) + "");
                Console.WriteLine($"A soma dos números desse array é: {somador}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para entrar no array");
                Console.ReadKey();
            }
}
    }
}
