using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EncuestaRealizada
    {
        [Key]
        [Column(Order = 0)]
        public int idAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idEncuesta { get; set; }

        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idEncuesta")]
        public virtual Encuesta encuesta { get; set; }
    }
}
