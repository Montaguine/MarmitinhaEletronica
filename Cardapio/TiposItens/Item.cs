using System;
using System.Text.Json.Serialization;

namespace Cardapio.TiposItems
{
    public class Item
    {
        public int Id { get; set; } // Id adicionado

        public string Nome { get; set; }
        public TipoPrato Tipo { get; set; }
        public bool Vegetariano { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Item() { }

        public Item(int id, string nome, TipoPrato tipo, bool vegetariano, decimal preco, string descricao, double calorias)
        {
            Id = id;
            Nome = nome;
            Vegetariano = vegetariano;
            Tipo = tipo;
            Preco = preco;
            Descricao = descricao;
            Calorias = calorias;
        }
    }
}
