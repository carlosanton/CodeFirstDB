using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Respuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string respuesta { get; set; }
        public bool esActivo { get; set; }
        public decimal nota { get; set; }
        public int? idPregunta { get; set; }
        public int idAlumno { get; set; }
        
        [ForeignKey("idPregunta")]
        public virtual Pregunta pregunta { get; set; }
        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
    }
}
