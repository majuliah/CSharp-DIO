using System;

namespace NuggetSerializarEatributos.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }

        public Vendas(int id, string nome, decimal valor, DateTime dataVenda)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            DataVenda = dataVenda;
        }
        public Vendas(int id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
    }
}