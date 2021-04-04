using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIBiblioteca.Entities;

namespace WEBAPIBiblioteca.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        {
        }

        public DbSet<Libro> Libro { get; set; }
        public DbSet<Autor> Autor { get; set; }
    }
}
