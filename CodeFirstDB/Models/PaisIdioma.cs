using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class PaisIdioma
    {
        [Key]
        [Column(Order = 0)]
        public int idPais { get; set; }
        [Key]
        [Column(Order = 1)]
        public int idIdioma { get; set; }
        public string nombre { get; set; }

        [ForeignKey("idPais")]
        public virtual Pais pais { get; set; }
        [ForeignKey("idIdioma")]
        public virtual Idioma idioma { get; set; }
    }
}
