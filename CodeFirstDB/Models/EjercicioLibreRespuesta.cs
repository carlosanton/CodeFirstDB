using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EjercicioLibreRespuesta
    {
        [Key]
        [Column(Order = 0)]
        public int idEjercicioLibre { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idRespuesta { get; set; }

        [ForeignKey("idEjercicioLibre")]
        public virtual EjercicioLibre ejercicioLibre { get; set; }
        [ForeignKey("idRespuesta")]
        public virtual Respuesta respuesta { get; set; }
    }
}
