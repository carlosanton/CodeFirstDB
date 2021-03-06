using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Alumno
    {
        [Key]
        public int idUsuario { get; set; }
        public string paginaPersonal { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }


        [ForeignKey("idUsuario")]
        public virtual Usuario usuario { get; set; }
    }
}
