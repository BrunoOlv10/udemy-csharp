using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes
{
    public class Carro
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; set; }
        public bool EstaAlugado { get; set; }
        public double PrecoAluguel { get; set; }
        public int Senha { get; set; }

        public Carro(string Marca, string Modelo, double PrecoAluguel, int Senha)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.PrecoAluguel = PrecoAluguel;
            this.Senha = Senha;
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

        public void MudarPrecoAluguel(int senha, double novoPrecoAluguel)
        {
            if (this.Senha == senha)
            {
                this.PrecoAluguel = novoPrecoAluguel;
                Console.WriteLine("Preço do aluguel alterado com sucesso!");
            }
            else
                Console.WriteLine($"Senha incorreta! Não autorizado a mudança de preço do aluguel do carro {Marca} {Modelo}");
        }
    }
}
