using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CuestionarioRespuesta
    {
        [Key]
        [Column(Order = 0)]
        public int idCuestionario { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idRespuesta { get; set; }

        [ForeignKey("idCuestionario")]
        public virtual Cuestionario cuestionario { get; set; }
        [ForeignKey("idRespuesta")]
        public virtual Respuesta respuesta { get; set; }
    }
}
