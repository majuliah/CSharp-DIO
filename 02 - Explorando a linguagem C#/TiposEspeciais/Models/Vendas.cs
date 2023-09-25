using System;
using Newtonsoft.Json;

namespace NuggetSerializarEatributos.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")]
        public string Nome { get; set; }
        
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
        
    }
}