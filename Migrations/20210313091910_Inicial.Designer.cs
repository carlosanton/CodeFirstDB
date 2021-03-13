﻿// <auto-generated />
using System;
using CodeFirstDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstDB.Migrations
{
    [DbContext(typeof(MoocContext))]
    [Migration("20210313091910_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirstDB.Models.Alumno", b =>
                {
                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paginaPersonal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("CodeFirstDB.Models.AlumnoInsignia", b =>
                {
                    b.Property<int>("idAlumno")
                        .HasColumnType("int");

                    b.Property<int>("idInsignia")
                        .HasColumnType("int");

                    b.HasKey("idAlumno", "idInsignia");

                    b.HasIndex("idInsignia");

                    b.ToTable("AlumnoInsignia");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Idioma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Idioma");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Insignia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Insignia");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Pais", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prefijoTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("CodeFirstDB.Models.PaisIdioma", b =>
                {
                    b.Property<int>("idPais")
                        .HasColumnType("int");

                    b.Property<int>("idIdioma")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPais", "idIdioma");

                    b.HasIndex("idIdioma");

                    b.ToTable("PaisIdioma");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estiloWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("idPais")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idPais");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Alumno", b =>
                {
                    b.HasOne("CodeFirstDB.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("CodeFirstDB.Models.AlumnoInsignia", b =>
                {
                    b.HasOne("CodeFirstDB.Models.Alumno", "alumno")
                        .WithMany()
                        .HasForeignKey("idAlumno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstDB.Models.Insignia", "insignia")
                        .WithMany()
                        .HasForeignKey("idInsignia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("alumno");

                    b.Navigation("insignia");
                });

            modelBuilder.Entity("CodeFirstDB.Models.PaisIdioma", b =>
                {
                    b.HasOne("CodeFirstDB.Models.Idioma", "idioma")
                        .WithMany()
                        .HasForeignKey("idIdioma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstDB.Models.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("idPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idioma");

                    b.Navigation("pais");
                });

            modelBuilder.Entity("CodeFirstDB.Models.Usuario", b =>
                {
                    b.HasOne("CodeFirstDB.Models.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("idPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pais");
                });
#pragma warning restore 612, 618
        }
    }
}
