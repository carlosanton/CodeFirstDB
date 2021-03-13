using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class EntidadDocente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string logotipo { get; set; }
        public int idPais { get; set; }
        public string enlaceWeb { get; set; }

        [ForeignKey("idPais")]
        public virtual Pais pais { get; set; }
    }
}
