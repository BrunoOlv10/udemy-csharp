using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class Produto
    {
        public string Id { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public Produto(string id, string nomeProduto, string categoria, double preco)
        {
            this.Id = id;
            this.NomeProduto = nomeProduto;
            this.Categoria = categoria;
            this.Preco = preco;
        }
    }
}
