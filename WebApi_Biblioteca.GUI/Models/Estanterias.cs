//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_Biblioteca.GUI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estanterias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estanterias()
        {
            this.Estante = new HashSet<Estante>();
            this.Ejemplares = new HashSet<Ejemplares>();
        }
    
        public int EstanteriaID { get; set; }
        public string CodigoEstanteria { get; set; }
        public string Alto { get; set; }
        public string Ancho { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estante> Estante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ejemplares> Ejemplares { get; set; }
    }
}
