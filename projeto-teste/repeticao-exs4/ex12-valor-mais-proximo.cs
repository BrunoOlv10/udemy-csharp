using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex12_valor_mais_proximo
    {
        public static void EncontrarMaisProximo()
        {
            try
            {
                Console.Write("Digite uma sequência numérica (separados por vírgula): ");
                string entrada = Console.ReadLine();
                string[] entradaDividida = entrada.Trim().Split(',');
                int[] numeros = entradaDividida.Select(e => int.Parse(e)).ToArray();

                int menor = int.MaxValue;
                int maior = 0;

                foreach (int numero in numeros)
                {
                    if (numero < menor)
                        menor = numero;

                    if (numero > maior)
                        maior = numero;
                }

                Console.Write("Digite um número para verificar se está dentro do intervalo e mais próximo de qual extremo: ");
                int referencia = Convert.ToInt16(Console.ReadLine());

                int diferencaMenor = 0;
                int diferencaMaior = 0;

                if (referencia > menor)
                    diferencaMenor = referencia - menor;

                else
                    diferencaMenor = menor - referencia;

                if (referencia > maior)
                    diferencaMaior = referencia - maior;

                else
                    diferencaMaior = maior - referencia;

                Console.WriteLine();

                if (diferencaMenor < diferencaMaior)
                    Console.WriteLine($"A menor diferença do número referência {referencia} é para o número {menor} e a diferença é de {diferencaMenor}");

                else
                    Console.WriteLine($"A menor diferença do número referência {referencia} é para o número {maior} e a diferença é de {diferencaMaior}");

                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números");
                Console.ReadKey();
            }
        }
    }
}
