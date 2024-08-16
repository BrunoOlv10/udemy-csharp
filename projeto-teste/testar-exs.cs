using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            int mes = ex21_dias_mes.obterMes();

            bool diasMes = ex21_dias_mes.obterDiasMes(mes);
        }
    }
}
