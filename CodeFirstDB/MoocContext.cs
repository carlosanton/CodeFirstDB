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
        public virtual DbSet<AccesoCurso> AccesoCurso { get; set; }
        public virtual DbSet<AccesoWeb> AccesoWeb { get; set; }
        public virtual DbSet<Encuesta> Encuesta { get; set; }
        public virtual DbSet<EncuestaRealizada> EncuestaRealizada { get; set; }
        public virtual DbSet<EjercicioTest> EjercicioTest { get; set; }
        public virtual DbSet<Cuestionario> Cuestionario { get; set; }
        public virtual DbSet<CuestionarioRealizado> CuestionarioRealizado { get; set; }
        public virtual DbSet<CorreccionProfesor> CorreccionProfesor { get; set; }
        public virtual DbSet<CorreccionAlumno> CorreccionAlumno { get; set; }
        public virtual DbSet<CorreccionAlumnoProfesor> CorreccionAlumnoProfesor { get; set; }
        public virtual DbSet<CursoProfesor> CursoProfesor { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<EncuestaPregunta> EncuestaPregunta { get; set; }
        public virtual DbSet<EjercicioTestPregunta> EjercicioTestPregunta { get; set; }
        public virtual DbSet<EjercicioLibre> EjercicioLibre { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<EjercicioLibreRespuesta> EjercicioLibreRespuesta { get; set; }
        public virtual DbSet<AlumnoRespuesta> AlumnoRespuesta { get; set; }
        public virtual DbSet<CuestionarioRespuesta> CuestionarioRespuesta { get; set; }
        public virtual DbSet<EjercicioTestRespuesta> EjercicioTestRespuesta { get; set; }
        public virtual DbSet<EncuestaRespuesta> EncuestaRespuesta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tutoria
            modelBuilder.Entity<Tutoria>().HasOne(x => x.profesor).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Anuncio
            modelBuilder.Entity<Anuncio>().HasOne(x => x.profesor).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Matricula
            modelBuilder.Entity<Matricula>().HasOne(x => x.curso).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Temario
            modelBuilder.Entity<Temario>().HasOne(x => x.profesor).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Corrección Alumno
            modelBuilder.Entity<CorreccionAlumno>().HasOne(x => x.alumno).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Corrección Profesor
            modelBuilder.Entity<CorreccionProfesor>().HasOne(x => x.profesor).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Nota
            modelBuilder.Entity<Nota>().HasOne(x => x.alumno).WithMany().OnDelete(DeleteBehavior.Restrict);

            // Entrada
            modelBuilder.Entity<Entrada>().HasOne(x => x.hilo).WithMany().OnDelete(DeleteBehavior.Restrict);

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

            // Acceso-Curso
            modelBuilder.Entity<AccesoCurso>(entity =>
            {
                entity.HasKey(x => new { x.idAlumno, x.idCurso });
                entity.HasOne("curso").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Acceso-Web
            modelBuilder.Entity<AccesoWeb>(entity =>
            {
                entity.HasKey(x => new { x.idUsuario, x.fechaAcceso });
            });

            // Encuesta realizada
            modelBuilder.Entity<EncuestaRealizada>(entity =>
            {
                entity.HasKey(x => new { x.idAlumno, x.idEncuesta });
                entity.HasOne("encuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Cuestionario realizado
            modelBuilder.Entity<CuestionarioRealizado>(entity =>
            {
                entity.HasKey(x => new { x.idAlumno, x.idCuestionario });
                entity.HasOne("cuestionario").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Corrección Alumno - Profesor
            modelBuilder.Entity<CorreccionAlumnoProfesor>(entity =>
            {
                entity.HasKey(x => new { x.idCorreccionAlumno, x.idProfesor });
                entity.HasOne("profesor").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Curso - Profesor
            modelBuilder.Entity<CursoProfesor>(entity =>
            {
                entity.HasKey(x => new { x.idCurso, x.idProfesor });
                entity.HasOne("profesor").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Encuesta - Pregunta
            modelBuilder.Entity<EncuestaPregunta>(entity =>
            {
                entity.HasKey(x => new { x.idEncuesta, x.idPregunta });
                entity.HasOne("pregunta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Ejercicio Test - Pregunta
            modelBuilder.Entity<EjercicioTestPregunta>(entity =>
            {
                entity.HasKey(x => new { x.idEjercicioTest, x.idPregunta });
                entity.HasOne("pregunta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Ejercicio Libre - Respuesta
            modelBuilder.Entity<EjercicioLibreRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idEjercicioLibre, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Alumno - Respuesta
            modelBuilder.Entity<AlumnoRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idAlumno, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Cuestionario - Respuesta
            modelBuilder.Entity<CuestionarioRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idCuestionario, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Ejercicio Test - Respuesta
            modelBuilder.Entity<EjercicioTestRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idEjercicioTest, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Encuesta - Respuesta
            modelBuilder.Entity<EncuestaRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idEncuesta, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });

            // Corrección Alumno - Respuesta
            modelBuilder.Entity<CorreccionAlumnoRespuesta>(entity =>
            {
                entity.HasKey(x => new { x.idCorreccionAlumno, x.idRespuesta });
                entity.HasOne("respuesta").WithMany().OnDelete(DeleteBehavior.Restrict);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MoocDBTest;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=MoocDBTest;User Id=sa;Password=VaxiDrez$;");
        }
    }
}
