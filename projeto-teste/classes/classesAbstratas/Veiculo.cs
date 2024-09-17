using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.classes.classesAbstratas
{
    public class Veiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        protected DateTime DataManutencao { get; private set; }

        public Veiculo (string marca, string modelo, string cor, DateTime dataManutencao)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.DataManutencao = dataManutencao;
        }
    }
}
