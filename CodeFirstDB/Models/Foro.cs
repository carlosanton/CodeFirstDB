using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Foro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idCurso { get; set; }

        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
    }
}
