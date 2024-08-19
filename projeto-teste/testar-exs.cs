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
            int[] tamanhoMatriz = ex30_excluir_valor_matriz.ObterTamanhoMatriz();

            int[] elementosMatriz = ex30_excluir_valor_matriz.ObterElementosMatriz(tamanhoMatriz);

            int[] excluirElementoMatriz = ex30_excluir_valor_matriz.ExcluirValorMatriz(elementosMatriz);
        }
    }
}
