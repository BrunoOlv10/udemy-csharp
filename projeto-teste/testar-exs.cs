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
            int numeroTermos = repeticao_exs.ex23_sequencia_fibonacci.ObterNumerosTermos();

            List<int> gerarSequencia = repeticao_exs.ex23_sequencia_fibonacci.GerarSequencia(numeroTermos);
        }
    }
}
