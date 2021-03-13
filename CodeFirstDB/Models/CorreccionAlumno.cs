using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CorreccionAlumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string comoCorregir { get; set; }
        public decimal nota { get; set; }
        public DateTime fecha { get; set; }
        public int idAlumno { get; set; }
        public int idActividad { get; set; }

        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idActividad")]
        public virtual Actividad actividad { get; set; }
    }
}
