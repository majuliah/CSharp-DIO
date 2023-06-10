using System;
using CrudSeries.Enums;

namespace CrudSeries.Entities
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            return $"Gênero: {Genero}\n" +
                   $"Título: {Titulo}\n" +
                   $"Descrição: {Descricao}\n" +
                   $"Ano de Lançamento: {Ano}";
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public int GetId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}