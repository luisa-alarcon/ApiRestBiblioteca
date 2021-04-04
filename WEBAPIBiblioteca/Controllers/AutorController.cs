using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIBiblioteca.Contexts;
using WEBAPIBiblioteca.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPIBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AppDbContext context;

        public AutorController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<AutorController>
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            return context.Autor.ToList();
        }

        // GET api/<AutorController>/5
        [HttpGet("{id}")]
        public Autor Get(int id)
        {
            var autor = context.Autor.FirstOrDefault(l => l.AutorID == id);
            return autor;
        }

        // POST api/<AutorController>
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            try
            {
                context.Autor.Add(autor);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        // PUT api/<AutorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {
            if (autor.AutorID == id)
            {
                context.Entry(autor).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();

            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<AutorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var autor = context.Autor.FirstOrDefault(l => l.AutorID== id);
            if (autor != null)
            {
                context.Autor.Remove(autor);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
