using System;

namespace NuggetSerializarEatributos.Models
{
    public class VendasDeserializadas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
        
        public VendasDeserializadas(int id, string nome, decimal valor, DateTime dataVenda)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            DataVenda = dataVenda;
        }
    }
}