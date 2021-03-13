using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstDB.Models
{
    public class Alumno
    {
        [Key]
        public int idUsuario { get; set; }
        public string paginaPersonal { get; set; }
        public string linkedIn { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }


        [ForeignKey("idUsuario")]
        public virtual Usuario usuario { get; set; }
    }
}
