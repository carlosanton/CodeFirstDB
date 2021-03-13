using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CuestionarioRealizado
    {
        [Key]
        [Column(Order = 0)]
        public int idAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idCuestionario { get; set; }
        public decimal nota { get; set; }

        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idCuestionario")]
        public virtual Cuestionario cuestionario { get; set; }
    }
}
