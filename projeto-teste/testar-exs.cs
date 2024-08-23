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
            string[] strings = ex32_ordenar_strings_buble_sort.ObterStrings();

            string[] bubleSort = ex32_ordenar_strings_buble_sort.BubbleSort(strings);
        }
    }
}
