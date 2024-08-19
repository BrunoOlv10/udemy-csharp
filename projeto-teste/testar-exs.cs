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
            int[] tamanhoMatriz = ex26_soma_elementos_matriz.TamanhoMatriz();

            int[] elementosMatriz = ex26_soma_elementos_matriz.ElementosMatriz(tamanhoMatriz);

            int somaElementos = ex26_soma_elementos_matriz.SomarElementosMatriz(elementosMatriz);
        }
    }
}
