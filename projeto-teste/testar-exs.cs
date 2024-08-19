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
            char limiteLetras = ex24_letras_alfabeto.obterNumeroLetras();

            List<char> alfabeto = ex24_letras_alfabeto.exibirAlfabeto(limiteLetras);
        }
    }
}
