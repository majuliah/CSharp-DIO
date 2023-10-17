namespace iniciandoAPIs.Entities
{
    /// <summary>
    /// Uma entidade é uma classe do programa que representa uma tabela no banco de dados
    /// </summary>
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}