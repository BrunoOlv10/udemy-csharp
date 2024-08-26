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
            (int numero1, int numero2) = repeticao_exs.ex7_numero_positivo_negativo.ObterNumeros();

            bool objetivo = repeticao_exs.ex7_numero_positivo_negativo.ObterResultado(numero1, numero2);
        }
    }
}
