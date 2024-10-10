using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex18_palindromo
    {
        public static void IdentificarPalindromo()
        {
            try
            {
                Console.Write("Digite um ou vários elementos para verificar se é um palíndromo (separados por vírgula): ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                    throw new Exception();

                string[] elementosDivididos = entrada.Split(',');

                Console.WriteLine();

                string[] elementosInvertidos = new string[elementosDivididos.Length];

                for (int i = 0; i < elementosDivididos.Length; i++)
                {
                    elementosDivididos[i] = elementosDivididos[i].Trim();
                    elementosInvertidos[i] = new string(elementosDivididos[i].Reverse().ToArray());
                }

                Dictionary<bool, List<string>> resultadoPalindromos = new Dictionary<bool, List<string>>()
                {
                    { true, new List<string>() },
                    { false, new List<string>() }
                };

                for (int i = 0; i < elementosDivididos.Length; i++)
                {
                    if (elementosDivididos[i].Equals(elementosInvertidos[i], StringComparison.OrdinalIgnoreCase))
                        resultadoPalindromos[true].Add(elementosDivididos[i]);

                    else
                        resultadoPalindromos[false].Add(elementosDivididos[i]);
                }

                Console.WriteLine("Elementos Inseridos: ");
                foreach (var resultado in resultadoPalindromos)
                {
                    string status = resultado.Key ? "É palíndromo" : "Não é palíndromo";
                    foreach (var elemento in resultado.Value)
                        Console.WriteLine($"{elemento} - {status}");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário digitar algo para verificar se é palíndriomo");
                Console.ReadKey();
            }
        }
    }
}
