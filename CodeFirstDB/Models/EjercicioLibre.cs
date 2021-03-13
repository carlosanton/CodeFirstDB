using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EjercicioLibre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string enunciado { get; set; }
        public DateTime inicioEjercicio { get; set; }
        public DateTime finEjercicio { get; set; }
        public DateTime? inicioCorreccion { get; set; }
        public DateTime? finCorreccion { get; set; }
        public bool esActivo { get; set; }
        public bool training { get; set; }
        public decimal nota { get; set; }
        public int idActividad { get; set; }

        [ForeignKey("idActividad")]
        public virtual Actividad actividad { get; set; }
    }
}
