using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class ex20_ano_nascimento
    {
        public static int ObterIdade()
        {
            Console.Write("Qual é a sua idade? ");
            int idade = Convert.ToInt16(Console.ReadLine());

            return idade;
        }

        public static int CalcularAnoNascimento(int idade)
        {
            DateTime data_atual = DateTime.Today;

            int AnoNasc = data_atual.Year - idade;

            Console.Write($"Se o usuário tem {idade}, o ano de nascimento é {AnoNasc}");
            Console.ReadKey();

            return AnoNasc;
        }
    }
}
