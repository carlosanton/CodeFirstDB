using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Subforo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idForo { get; set; }
        
        [ForeignKey("idForo")]
        public virtual Foro foro { get; set; }
    }
}
