using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public bool EstaAlugado { get; set; }
        public double PrecoAluguel { get; set; }

        public Carro(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("O carro está ligado!");
        }

        public void Desligar()
        {
            Console.WriteLine("O carro está desligado!");
        }

        public void Alugar()
        {
            EstaAlugado = true;
            Console.WriteLine($"O carro da marca {Marca} foi alugado com sucesso");
        }

        public string EstadoAluguel()
        {
            return EstaAlugado == true ? "Sim" : "Não";
        }

        public void DevolverCarro()
        {
            EstaAlugado = false;
            Console.WriteLine($"O carro {Marca} foi devolvido");
        }
    }
}
