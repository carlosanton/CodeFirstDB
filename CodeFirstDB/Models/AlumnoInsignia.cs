using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class AlumnoInsignia
    {
        [Key]
        [Column(Order = 0)]
        public int idAlumno { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idInsignia { get; set; }

        [ForeignKey("idAlumno")]
        public virtual Alumno alumno { get; set; }
        [ForeignKey("idInsignia")]
        public virtual Insignia insignia { get; set; }
    }
}
