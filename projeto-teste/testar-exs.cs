using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.classes;
using curso_udemy.recuperar_instituicao_ano;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace projeto
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            int[] numeros =repeticao_exs2.ex27_transferir_elementos_array.ObterInfosArray();

            repeticao_exs2.ex27_transferir_elementos_array.TransferirArray(numeros);
        }
    }
}
