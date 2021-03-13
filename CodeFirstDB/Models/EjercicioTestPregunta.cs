using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EjercicioTestPregunta
    {
        [Key]
        [Column(Order = 0)]
        public int idEjercicioTest { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idPregunta { get; set; }

        [ForeignKey("idEjercicioTest")]
        public virtual EjercicioTest ejercicioTest { get; set; }
        [ForeignKey("idPregunta")]
        public virtual Pregunta pregunta { get; set; }
    }
}
