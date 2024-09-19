using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes.Interfaces
{
    public interface ICarro
    {
        void ProximaManutencao(int dias);
        string EstadoAluguel();
        void MudarPrecoAluguel(double NovoPreco);
    }
}
