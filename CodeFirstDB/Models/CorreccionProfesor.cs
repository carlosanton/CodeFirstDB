using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class CorreccionProfesor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public decimal nota { get; set; }
        public DateTime fecha { get; set; }
        public int idProfesor { get; set; }
        public int idActividad { get; set; }

        [ForeignKey("idProfesor")]
        public virtual Profesor profesor { get; set; }
        [ForeignKey("idActividad")]
        public virtual Actividad actividad { get; set; }
    }
}
