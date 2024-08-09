using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    internal class ex14_soma_matriz
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite os números que vão entrar na matriz (separe cada um por vírgula): ");
                string entrada = Console.ReadLine();
                string[] numeros = entrada.Split(',');
                int[] matrizInteiros = new int[numeros.Length];

                for (int i = 0; i < numeros.Length; i++)
                {
                    matrizInteiros[i] = Convert.ToInt16(numeros[i].Trim());
                }

                int soma = 0;

                for (int i = 0; i < matrizInteiros.Length; i++)
                {
                    soma += matrizInteiros[i];
                }

                Console.WriteLine($"A soma entre os números da matrizes é igual a {soma}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("É necessário separar os números por vírgula!");
            }
            Console.ReadKey();
        }
    }
}
