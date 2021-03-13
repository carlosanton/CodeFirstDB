using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CorreccionAlumnoRespuesta
    {
        [Key]
        [Column(Order = 0)]
        public int idCorreccionAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idRespuesta { get; set; }

        [ForeignKey("idCorreccionAlumno")]
        public virtual CorreccionAlumno correccionAlumno { get; set; }
        [ForeignKey("idRespuesta")]
        public virtual Respuesta respuesta { get; set; }
    }
}
