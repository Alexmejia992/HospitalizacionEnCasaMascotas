using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasaMascotas.App.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Veterinario_contraseña",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Veterinario_correo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Veterinario_contraseña",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Veterinario_correo",
                table: "Personas");
        }
    }
}
