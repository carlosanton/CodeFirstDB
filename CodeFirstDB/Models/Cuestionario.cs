using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Cuestionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal nota { get; set; }
        public bool esActivo { get; set; }
        public DateTime inicioCuestionario { get; set; }
        public DateTime? finCuestionario { get; set; }
        public DateTime? inicioCorreccion { get; set; }
        public DateTime? finCorreccion { get; set; }
        public int idTemario { get; set; }

        [ForeignKey("idTemario")]
        public virtual Temario temario { get; set; }
    }
}
