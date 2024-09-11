using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex20_ano_nascimento
    {
        public static int ObterIdade()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite sua idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    return idade;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números para a idade!");
                }
            }
        }

        public static int CalcularAnoNascimento(int idade)
        {
            int anoAtual = DateTime.Now.Year;

            int anoNascimento = anoAtual - idade;

            Console.WriteLine();
            Console.WriteLine($"O usuário tem {idade} anos e nasceu no ano de {anoNascimento}");
            Console.ReadKey();

            return anoNascimento;
        }
    }
}
