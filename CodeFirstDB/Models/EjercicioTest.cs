using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EjercicioTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal nota { get; set; }
        public DateTime inicioTest { get; set; }
        public DateTime? finTest { get; set; }
        public DateTime? inicioCorreccion { get; set; }
        public DateTime? finCorreccion { get; set; }
        public bool esActivo { get; set; }
        public int idActividad { get; set; }
        
        [ForeignKey("idActividad")]
        public virtual Actividad actividad { get; set; }
    }
}
