using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Matricula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime fechaMatricula { get; set; }
        public int idCurso { get; set; }
        public int idAlumno { get; set; }

        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
    }
}
