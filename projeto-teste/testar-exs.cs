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
            (int temperatura, string unidadeMedida) = repeticao_exs.ex19_conversao_graus_fahrenheit.ObterInfosTemperatura();

            int converterTemperatura = repeticao_exs.ex19_conversao_graus_fahrenheit.ConverterTemperatura(temperatura, unidadeMedida);
        }
    }
}
