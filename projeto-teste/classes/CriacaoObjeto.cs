﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using curso_udemy.classes.classesAbstratas;
using projeto.classes;
using projeto.classes.classesEstaticas;

namespace projeto
{
    public class CriacaoObjeto
    {
        public static void CriarObjeto()
        {
            Moto moto = new Moto("Kawasaki", "z1000", "Preto");
            //moto.ProximaManutencao(5);
            moto.ProximaManutencao();

            //Carro carro = new Carro("Nissan", "GTR", "azul", 1000, 1234);

            Carro carro = new Carro("Nissan", "GTR", "Azul", 1000);
            carro.ProximaManutencao(10);

            Console.WriteLine($"Número de pneus {carro.NumeroPneus}");

            CarrosDadosBasicos.ConsumoMedio(150, 10);
            Console.WriteLine();

            List<Carro> listaCarros = new List<Carro>();
            listaCarros.Add(carro);
            listaCarros.Add(new Carro("VW", "Passat", "Cinza", 450));

            //Console.WriteLine($"Número de elementos da lista {listaCarros.Count}");

            foreach (var car in listaCarros)
            {
                Console.WriteLine($"Marcas de carro: { car.Marca } e da cor { car.Cor }");
                car.ProximaManutencao();
            }

            Console.WriteLine();
            Console.Write("Insira o novo preço do aluguel: ");
            var preco = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Insira a senha cadastrada (apenas números): ");
            //int senha = Convert.ToInt32(Console.ReadLine());
            int senha = 0;

            Console.WriteLine();

            //carro.MudarPrecoAluguel(senha, preco);
            carro.MudarPrecoAluguel(preco);

            Console.WriteLine();

            Console.WriteLine($"Meu primeiro carro da frota é da marca: {carro.Marca} e do modelo {carro.Modelo} e com preço de aluguel " +
                $"{carro.PrecoAluguel}");

            carro.ProximaManutencao();

            //Console.Write("Quer alugar esse carro (coloque 'sim' ou 'não'): ");
            //string alugar = Console.ReadLine().ToLower();

            //if (alugar == "sim")
            //    carro.Alugar();
            //else
            //    Console.WriteLine("O carro não foi alugado");

            //Console.WriteLine($"O {carro.Marca} está alugado? {carro.EstadoAluguel()}");

            Console.ReadKey();
        }
    }
}
