using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class AccesoWeb
    {
        [Key]
        [Column(Order = 0)]
        public int idUsuario { get; set; }
        [Key]
        [Column(Order = 1)]
        public DateTime fechaAcceso { get; set; }

        [ForeignKey("idUsuario")]
        public virtual Usuario usuario { get; set; }
    }
}
