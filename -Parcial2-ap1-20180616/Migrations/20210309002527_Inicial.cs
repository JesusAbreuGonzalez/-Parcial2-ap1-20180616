using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _Parcial2_ap1_20180616.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    TiempoTotal = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "TiposTarea",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTarea", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "ProyectosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoTareaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposTarea",
                columns: new[] { "TipoId", "Descripcion", "Requerimiento", "Tiempo" },
                values: new object[] { 1, "Análisis", "Analizar la opción de clientes", 120 });

            migrationBuilder.InsertData(
                table: "TiposTarea",
                columns: new[] { "TipoId", "Descripcion", "Requerimiento", "Tiempo" },
                values: new object[] { 2, "Diseño", "Hacer un diseño excelente", 60 });

            migrationBuilder.InsertData(
                table: "TiposTarea",
                columns: new[] { "TipoId", "Descripcion", "Requerimiento", "Tiempo" },
                values: new object[] { 3, "Programación", "Programar todo el registro", 240 });

            migrationBuilder.InsertData(
                table: "TiposTarea",
                columns: new[] { "TipoId", "Descripcion", "Requerimiento", "Tiempo" },
                values: new object[] { 4, "Prueba", "Probar con mucho cuidado", 30 });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosDetalle_ProyectoId",
                table: "ProyectosDetalle",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProyectosDetalle");

            migrationBuilder.DropTable(
                name: "TiposTarea");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
