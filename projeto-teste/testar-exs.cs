using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            int[] numerosMatriz = ex25_elementos_matriz.obterElementosMatriz();

            int[] matrizGerada = ex25_elementos_matriz.exibirNumerosMatriz(numerosMatriz);
        }
    }
}
