using CodeFirstDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDB
{
    public class MoocContext : DbContext
    {
        public MoocContext()
        {

        }

        public MoocContext(DbContextOptions<MoocContext> options) : base(options)
        {

        }

        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<PaisIdioma> PaisIdioma { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Insignia> Insignia { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoInsignia> AlumnoInsignia { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<EntidadDocente> EntidadDocente { get; set; }
        public virtual DbSet<Gestor> Gestor { get; set; }
        public virtual DbSet<Foro> Foro { get; set; }
        public virtual DbSet<Subforo> Subforo { get; set; }
        public virtual DbSet<Hilo> Hilo { get; set; }
        public virtual DbSet<Entrada> Entrada { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Tutoria> Tutoria { get; set; }
        public virtual DbSet<Temario> Temario { get; set; }
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Anuncio> Anuncio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // País idioma
            modelBuilder.Entity<PaisIdioma>(entity =>
            {
                entity.HasKey(x => new { x.idPais, x.idIdioma });
            });

            // Alumno-Insignia
            modelBuilder.Entity<AlumnoInsignia>(entity =>
            {
                entity.HasKey(x => new { x.idAlumno, x.idInsignia });
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MoocDBTest;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=MoocDBTest;User Id=sa;Password=VaxiDrez$;");
        }
    }
}
