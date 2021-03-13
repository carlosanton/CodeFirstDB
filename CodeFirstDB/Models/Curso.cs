using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Models
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string imagen { get; set; }
        public string video { get; set; }
        public int dificultad { get; set; }
        public string conocimientoPrevio { get; set; }
        public string anyoAcademico { get; set; }
        public bool esActivo { get; set; }
        public int idGestor { get; set; }
        public int idCategoria { get; set; }

        [ForeignKey("idGestor")]
        public virtual Gestor gestor { get; set; }
        [ForeignKey("idCategoria")]
        public virtual Categoria categoria { get; set; }
    }
}
