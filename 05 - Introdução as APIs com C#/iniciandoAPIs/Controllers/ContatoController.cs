using iniciandoAPIs.Context;
using iniciandoAPIs.Entities;
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

        [HttpGet("{id}")]
        public IActionResult ObterId(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            if(contato == null)
                return NotFound();
            
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarId(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
                return NotFound();
            
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
            
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarId(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
                return NotFound();
            
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}