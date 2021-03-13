using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public decimal nota { get; set; }
        public bool esActivo { get; set; }
        public int idActividad { get; set; }
        public int idAlumno { get; set; }

        [ForeignKey("idActividad")]
        public virtual Actividad actividad { get; set; }
        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
    }
}
