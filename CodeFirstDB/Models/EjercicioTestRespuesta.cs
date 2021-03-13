using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EjercicioTestRespuesta
    {
        [Key]
        [Column(Order = 0)]
        public int idEjercicioTest { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idRespuesta { get; set; }

        [ForeignKey("idEjercicioTest")]
        public virtual EjercicioTest ejercicioTest { get; set; }
        [ForeignKey("idRespuesta")]
        public virtual Respuesta respuesta { get; set; }
    }
}
