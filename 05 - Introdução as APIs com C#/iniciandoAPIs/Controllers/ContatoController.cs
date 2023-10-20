using iniciandoAPIs.Context;
using Microsoft.AspNetCore.Mvc;

namespace iniciandoAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController: ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost("CriarContato")]
        public IActionResult Create(ContatoController contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}