using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_Biblioteca.GUI.Models.DTO
{
    public class Publicacion
    {
        [Display(Name = "ID")]
        [Required]
        public int PublicacionID { get; set; }

        [Display(Name = "Tematica")]
        [Required]
        public string Tematica { get; set; }

        [Display(Name = "Idioma")]
        [Required]
        public string Idioma { get; set; }

        [Display(Name = "Fecha de Publicacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaPublicacion { get; set; }

        [Display(Name = "Editorial")]
        [Required]
        public string Editorial { get; set; }

        [Display(Name = "ID EJEMPLAR")]
        [Required]
        public int EjemplarID { get; set; }

        [Display(Name = "Tipo Publicacion")]
        public string TipoPublicacion { get; set; }
    }

}
