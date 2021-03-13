using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime inicioEncuesta { get; set; }
        public DateTime finEncuesta { get; set; }
        public bool esActivo { get; set; }
        public string nombre { get; set; }
        public int idCurso { get; set; }

        [ForeignKey("idCurso")]
        public virtual Curso curso { get; set; }
    }
}
