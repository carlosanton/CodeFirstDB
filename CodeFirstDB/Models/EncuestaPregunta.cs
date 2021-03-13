using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EncuestaPregunta
    {
        [Key]
        [Column(Order = 0)]
        public int idEncuesta { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idPregunta { get; set; }

        [ForeignKey("idEncuesta")]
        public virtual Encuesta encuesta { get; set; }
        [ForeignKey("idPregunta")]
        public virtual Pregunta pregunta { get; set; }
    }
}
