using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class AccesoCurso
    {
        [Key]
        [Column(Order = 0)]
        public int idAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idCurso { get; set; }
        public bool matriculado { get; set; }
        
        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
    }
}
