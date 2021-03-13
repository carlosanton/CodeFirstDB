using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Profesor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string paginaPersonal { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public bool esActivo { get; set; }
        public int idEntidadDocente { get; set; }

        [ForeignKey("idEntidadDocente")]
        public virtual EntidadDocente entidadDocente { get; set; }
    }
}
