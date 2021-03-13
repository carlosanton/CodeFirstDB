using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Gestor
    {
        [Key]
        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public virtual Usuario usuario { get; set; }
    }
}
