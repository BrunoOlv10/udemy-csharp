using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex24_letras_alfabeto
    {
        public static void ExibirAlfabeto()
        {
            try
            {
                Console.Write("Insira até qual letra será exibido o alfabeto (A-Z): ");
                char letraLimite = char.ToUpper(Console.ReadLine()[0]);

                Console.WriteLine();

                if (letraLimite < 'A' || letraLimite > 'Z')
                    throw new Exception();

                for (char letra = 'A'; letra <= letraLimite; letra++)
                {
                    Console.Write(letra);

                    if (letra < letraLimite)
                        Console.Write(", ");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira uma letra de A a Z");
                Console.ReadLine();
            }
        }
    }
}
