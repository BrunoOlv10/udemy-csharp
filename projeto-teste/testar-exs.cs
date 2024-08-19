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
            int[] tamanhoMatriz = ex28_ocorrencias_matriz.ObterTamanhoMatriz();

            int[] elementosMatriz = ex28_ocorrencias_matriz.ObterElementosMatriz(tamanhoMatriz);

            Dictionary<int, int> elementosRepetidos = ex28_ocorrencias_matriz.ElementosRepetidos(elementosMatriz);
        }
    }
}
