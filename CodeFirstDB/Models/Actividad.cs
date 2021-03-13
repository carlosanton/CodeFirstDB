using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Actividad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public bool esActivo { get; set; }
        public int idTemario { get; set; }

        [ForeignKey("idTemario")]
        public virtual Temario temario { get; set; }
    }
}
