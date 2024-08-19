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
            int[] tamanhoMatriz = ex27_elementos_trocados_matriz.ObterTamanhoMatriz();

            int[] elementosMatriz = ex27_elementos_trocados_matriz.ObterElementosMatriz(tamanhoMatriz);

            int[] transferirMatriz = ex27_elementos_trocados_matriz.TransferirMatriz(elementosMatriz);

            int[] exibirMatrizes = ex27_elementos_trocados_matriz.ExibirMatrizes(elementosMatriz, transferirMatriz);
        }
    }
}
