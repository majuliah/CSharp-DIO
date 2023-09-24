using System;
using Newtonsoft.Json;

namespace NuggetSerializarEatributos.Models
{
    public class VendasSerializadas
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_produto")]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
        
        public VendasSerializadas(int id, string nome, decimal valor, DateTime dataVenda)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            DataVenda = dataVenda;
        }
    }
}