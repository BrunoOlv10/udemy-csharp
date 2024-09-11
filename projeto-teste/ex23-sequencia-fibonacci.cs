using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.EMMA;

namespace projeto
{
    public class ex23_sequencia_fibonacci
    {
        public static int obterNumeroTermos()
        {
            Console.Write("Digite o número de termos a ser exibidos (maior que 0): ");
            int numeroTermos = Convert.ToInt32(Console.ReadLine());

            while (numeroTermos < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Número de termos inválido!");
                Console.Write("Digite o número de termos a ser exibidos (maior que 0): ");
                numeroTermos = Convert.ToInt32(Console.ReadLine());
            }

            return numeroTermos;
        }

        public static List<int> gerarSequenciaFibonacci(int numeroTermos)
        {
            List<int> sequencia = new List<int>();
            int primeiroNumero = 0, segundoNumero = 1, proximoNumero;

            Console.WriteLine();

            if (numeroTermos >= 1)
                Console.Write($"{primeiroNumero}, ");

            if (numeroTermos >= 2)
                Console.Write($"{segundoNumero}, ");

            for (int i = 3; i <= numeroTermos; i++)
            {
                proximoNumero = primeiroNumero + segundoNumero;
                sequencia.Add(proximoNumero);
                primeiroNumero = segundoNumero;
                segundoNumero = proximoNumero;
            }
            Console.WriteLine(string.Join(", ", sequencia));
            Console.ReadKey();

            return sequencia;
        }
    }
}
