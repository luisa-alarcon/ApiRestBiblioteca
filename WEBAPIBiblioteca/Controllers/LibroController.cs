﻿using Microsoft.AspNetCore.Mvc;
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
    public class LibroController : ControllerBase
    {
        private readonly AppDbContext context;

        public LibroController(AppDbContext context )
        {
            this.context = context;
        }

        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return context.Libro.ToList();
        }

        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public Libro Get(int id)
        {
            var libro = context.Libro.FirstOrDefault(l=>l.LibroID == id);
            return libro;
        }

        // POST api/<LibroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
