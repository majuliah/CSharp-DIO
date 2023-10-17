using iniciandoAPIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace iniciandoAPIs.Context
{
    /// <summary>
    /// a classe dbcontext é do pacote entityframeworkcore
    /// Esse context faz a conexão com o banco de dados
    /// 
    /// </summary>
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}