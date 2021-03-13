using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CorreccionAlumnoProfesor
    {
        [Key]
        [Column(Order = 0)]
        public int idCorreccionAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idProfesor { get; set; }

        [ForeignKey("idCorreccionAlumno")]
        public virtual CorreccionAlumno correccionAlumno { get; set; }
        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
    }
}
