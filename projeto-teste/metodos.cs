using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    public class metodos
    {
        public static void ObterResultado()
        {
            int valor = 40;

            Console.Write("Insira um valor a somar: ");
            int valorUsuario = Convert.ToInt32(Console.ReadLine());

            SomarValor(ref valor);

            Console.WriteLine("Resultado: " + valor);
            Console.ReadKey();
        }

        private static void SomarValor(ref int valor, int intervalo = 0)
        {
            if (intervalo == 0)
                valor++;
            else
                valor = valor + intervalo;
        }
    }
}
