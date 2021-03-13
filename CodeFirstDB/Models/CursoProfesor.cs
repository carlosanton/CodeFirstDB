using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CursoProfesor
    {
        [Key]
        [Column(Order = 0)]
        public int idCurso { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idProfesor { get; set; }

        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
    }
}
