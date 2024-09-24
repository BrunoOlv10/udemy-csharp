using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.classes.classesAbstratas;
using projeto.classes.classesEstaticas;
using projeto.classes.Interfaces;

namespace projeto.classes
{
    public class Carro : Veiculo, ICarro
    {
        public bool EstaAlugado { get; private set; }
        public double PrecoAluguel { get; private set; }

        public string NumeroPneus { get; set; }
        public int Senha { get; set; }

        //public Carro(string Marca, string Modelo, string Cor, DateTime DataManutencao, double PrecoAluguel, int Senha) : base (Marca, Modelo, Cor, DataManutencao)
        public Carro(string Marca, string Modelo, string Cor, double PrecoAluguel) : base (Marca, Modelo, Cor)
        {
            this.PrecoAluguel = PrecoAluguel;
            this.NumeroPneus = CarrosDadosBasicos.NumeroPneus;
            //this.Senha = Senha;
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

        //public void MudarPrecoAluguel(int senha, double novoPrecoAluguel)
        public void MudarPrecoAluguel(double novoPrecoAluguel)
        {
            //if (this.Senha == senha)
            //{
                if (novoPrecoAluguel > PrecoAluguel)
                {
                    this.PrecoAluguel = novoPrecoAluguel;
                    Console.WriteLine("Preço do aluguel alterado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Usuário Admin acessado com sucesso!");
                    Console.WriteLine("Preço não alterado, pois o novo preço inserido é menor ou igual ao atual presente no sistema");
                }
            //}
            //else
            //    Console.WriteLine($"Senha incorreta! Não autorizado a mudança de preço do aluguel do carro {Marca} {Modelo}");
        }

        //public override void ProximaManutencao()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine($"O carro tem a manutenção especial para a data: {this.DataManutencao.AddDays(30)}");
        //}

        public void ProximaManutencao(int dias)
        {
            Console.WriteLine($"Próxima manutenção do carro em dias: {dias}");
            Console.WriteLine();
        }
    }
}
