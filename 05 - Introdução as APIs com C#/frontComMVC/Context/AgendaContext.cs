using frontComMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace frontComMVC.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {

    }
    public DbSet<Contato> Contatos { get; set; }
}
