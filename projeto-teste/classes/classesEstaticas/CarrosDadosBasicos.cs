using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes.classesEstaticas
{
    public class CarrosDadosBasicos
    {
        public static string NumeroPneus { get { return "4"; } }

        public static void ConsumoMedio(int kms, int litros)
        {
            Console.WriteLine($"O consumo médio do trecho foi { kms / litros }");
        }
    }
}
