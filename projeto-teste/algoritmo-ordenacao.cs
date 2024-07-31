using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    class algoritmo_ordenacao
    {
        static void Main(string[] args)
        {
            int[] vetor = { 100, 99, 55, 30, 90 };
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for(int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];

                        vetor[i] = vetor[j];

                        vetor[j] = aux;
                    }
                }
            }
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Resultado");
            Console.ReadKey();
        }
    }
}
