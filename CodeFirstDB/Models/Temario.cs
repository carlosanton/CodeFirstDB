using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Temario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public bool esActivo { get; set; }
        public int idCurso { get; set; }
        public int idProfesor { get; set; }

        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
    }
}
