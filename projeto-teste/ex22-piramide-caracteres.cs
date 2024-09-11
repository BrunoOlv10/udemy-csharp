using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ex22_piramide_caracteres
    {
        public static (string caractere, int numeroLinhas) obterElementoUtilizado()
        {
            Console.Write("Insira um caractere válido (apenas um caractere): ");
            var caractere = Console.ReadLine();

            while (caractere.Length != 1)
            {
                Console.WriteLine($"O caractere '{caractere}' não é válido");
                Console.Write("Insira um caractere válido (apenas um caractere): ");
                caractere = Console.ReadLine();
            }

            Console.Write("Insira um número dentro do limite (1 até 20): ");
            int numeroLinhas = Convert.ToInt32(Console.ReadLine());

            while (numeroLinhas < 1 || numeroLinhas > 20)
            {
                Console.WriteLine($"O número '{caractere}' não está dentro do permitido");
                Console.Write("Insira um número dentro do limite (1 até 20): ");
                numeroLinhas = Convert.ToInt32(Console.ReadLine());
            }

            return (caractere, numeroLinhas);
        }

        public static bool MontarPiramidade(string caractere, int numeroLinhas)
        {
            Console.WriteLine();
            for (int i = 1; i <= numeroLinhas; i++)
            {
                string linha = new string(caractere[0], i);
                Console.WriteLine(linha);
            }
                Console.ReadLine();

            return true;
        }
    }
}
