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
            int[] array = repeticao_exs.ex29_maior_menor_valor_array.ObterArray();

            (int maiorNumero, int menorNumero) = repeticao_exs.ex29_maior_menor_valor_array.MaiorMenorValor(array);
        }
    }
}
