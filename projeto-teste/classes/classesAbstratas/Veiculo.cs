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

        public Veiculo (string marca, string modelo, string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.DataManutencao = DateTime.Now;
        }

        public virtual void ProximaManutencao()
        {
            Console.WriteLine();
            //string dataFormatada = DataManutencao.ToString("dd/MM/yyyy");
            //Console.WriteLine($"O carro tem a manutenção padrão para a dataa: {dataFormatada}");
            Console.WriteLine($"O veículo tem a manutenção padrão para a dataa: {this.DataManutencao}");
        }
    }
}
