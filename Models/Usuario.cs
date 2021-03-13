using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string domicilio { get; set; }
        public string codigoPostal { get; set; }
        public int idPais { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string avatar { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string estiloWeb { get; set; }
        public bool activo { get; set; }

        [ForeignKey("idPais")]
        public virtual Pais pais { get; set; }
    }
}
