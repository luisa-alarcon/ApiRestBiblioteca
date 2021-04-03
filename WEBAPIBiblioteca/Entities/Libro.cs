using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIBiblioteca.Entities
{
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }
        public string  ISBM { get; set; }
        public string Titulo { get; set; }
        public string Formato { get; set; }
        public string NumeroPaginas { get; set; }
        public int PublicacionID { get; set; }
    }
}
