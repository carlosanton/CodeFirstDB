using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Hilo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public string texto { get; set; }
        public int votos { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idSubforo { get; set; }

        [ForeignKey("idSubforo")]
        public virtual Subforo Subforo { get; set; }
    }
}
