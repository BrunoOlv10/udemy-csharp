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
            (int numero1, int numero2) = repeticao_exs.ex1_trocar_numeros_variaveis.ObterNumeros();

            bool inverterNumeros = repeticao_exs.ex1_trocar_numeros_variaveis.InverterNumeros(numero1, numero2);
        }
    }
}
