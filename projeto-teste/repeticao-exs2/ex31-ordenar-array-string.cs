using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex31_ordenar_array_string
    {
        public static void OrdenarSring()
        {
            try
            {
                Console.Write("Escreva palavra(s) ou número(s) (cada um separado por vírgula): ");
                string elemento = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(elemento))
                    throw new Exception();

                string[] elementosDivididos = elemento.Split(',');

                for (int i = 0; elementosDivididos.Length > i; i++)
                    elementosDivididos[i] = elementosDivididos[i].Trim();

                Array.Sort(elementosDivididos);

                string stringOrdenada = String.Join(", ", elementosDivididos);

                Console.WriteLine();
                Console.WriteLine($"O elemento inicialmente era [ {elemento} ], após ordenada ficou [ {stringOrdenada} ]");
                Console.ReadKey();
            }
            catch (Exception ex) 
            {
                Console.WriteLine();
                Console.WriteLine("Insira algo para ser ordenado!");
                Console.ReadKey();
            }
        }
    }
}
