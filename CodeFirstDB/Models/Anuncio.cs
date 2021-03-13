using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string textoAnuncio { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idProfesor { get; set; }
        public int idCurso { get; set; }

        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
    }
}
