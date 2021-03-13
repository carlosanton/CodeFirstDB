using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EncuestaRespuesta
    {
        [Key]
        [Column(Order = 0)]
        public int idEncuesta { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idRespuesta { get; set; }

        [ForeignKey("idEncuesta")]
        public virtual Encuesta encuesta { get; set; }
        [ForeignKey("idRespuesta")]
        public virtual Respuesta respuesta { get; set; }
    }
}
