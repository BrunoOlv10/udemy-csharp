using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex1_trocar_elementos_variaveis
    {
        public static void TrocarElementosVariaveis()
        {
            Console.WriteLine("Insira dois elementos abaixo");
            string elemento1 = "", elemento2 = "";

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Insira o elemento {i + 1}: ");
                string entrada = Console.ReadLine();

                if (i == 0)
                    elemento1 = entrada;

                if (i == 1)
                    elemento2 = entrada;
            }

            var aux = elemento1;
            string elementoTrocado1 = elemento2;
            string elementoTrocado2 = aux;

            Console.WriteLine();
            Console.WriteLine($"Os elementos inseridos foram '{elemento1}' e '{elemento2}', após serem trocados de variável ficou '{elementoTrocado1}' e '{elementoTrocado2}'");
            Console.ReadKey();
        }
    }
}
