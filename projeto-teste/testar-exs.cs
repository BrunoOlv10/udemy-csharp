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
            (int[] array, int posicaoExcluida) = repeticao_exs.ex30_excluir_valor_array.ObterArray();

            int[] novoArray = repeticao_exs.ex30_excluir_valor_array.ArrayNovo(array, posicaoExcluida);
        }
    }
}
