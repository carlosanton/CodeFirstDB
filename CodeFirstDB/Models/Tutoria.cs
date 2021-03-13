using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Tutoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string duda { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idAlumno { get; set; }
        public int idProfesor { get; set; }

        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
    }
}
