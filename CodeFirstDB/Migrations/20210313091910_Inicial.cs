using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDB.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Insignia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    motivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insignia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prefijoTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaisIdioma",
                columns: table => new
                {
                    idPais = table.Column<int>(type: "int", nullable: false),
                    idIdioma = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisIdioma", x => new { x.idPais, x.idIdioma });
                    table.ForeignKey(
                        name: "FK_PaisIdioma_Idioma_idIdioma",
                        column: x => x.idIdioma,
                        principalTable: "Idioma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisIdioma_Pais_idPais",
                        column: x => x.idPais,
                        principalTable: "Pais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    domicilio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idPais = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estiloWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Pais_idPais",
                        column: x => x.idPais,
                        principalTable: "Pais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    paginaPersonal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twitter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Alumno_Usuario_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlumnoInsignia",
                columns: table => new
                {
                    idAlumno = table.Column<int>(type: "int", nullable: false),
                    idInsignia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoInsignia", x => new { x.idAlumno, x.idInsignia });
                    table.ForeignKey(
                        name: "FK_AlumnoInsignia_Alumno_idAlumno",
                        column: x => x.idAlumno,
                        principalTable: "Alumno",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlumnoInsignia_Insignia_idInsignia",
                        column: x => x.idInsignia,
                        principalTable: "Insignia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoInsignia_idInsignia",
                table: "AlumnoInsignia",
                column: "idInsignia");

            migrationBuilder.CreateIndex(
                name: "IX_PaisIdioma_idIdioma",
                table: "PaisIdioma",
                column: "idIdioma");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idPais",
                table: "Usuario",
                column: "idPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoInsignia");

            migrationBuilder.DropTable(
                name: "PaisIdioma");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Insignia");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
