using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIBiblioteca.Entities
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }
        public string NombreAutor { get; set; }
        public string ApellidoAutor { get; set; }
        public string Nacionalidad { get; set; }
    }
}
