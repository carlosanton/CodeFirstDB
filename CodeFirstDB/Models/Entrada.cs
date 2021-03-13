using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Entrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string texto { get; set; }
        public int votos { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idHilo { get; set; }
        public int idAlumno { get; set; }

        [ForeignKey("idHilo")]
        public virtual Hilo Hilo { get; set; }
        [ForeignKey("idAlumno")]
        public virtual Alumno Alumno { get; set; }
    }
}
