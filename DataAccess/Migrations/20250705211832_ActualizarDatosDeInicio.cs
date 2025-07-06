using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarDatosDeInicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContrasenaHash", "Nombre", "Usuario" },
                values: new object[] { "isa123", "Isela Cerritos Guzman", "isaguzman" });

            migrationBuilder.UpdateData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContrasenaHash", "Nombre", "Usuario" },
                values: new object[] { "root", "Alfredo Garcia Olmedo", "root" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContrasenaHash", "Nombre", "Usuario" },
                values: new object[] { "admin123", "Carlos Ramírez", "carlosr" });

            migrationBuilder.UpdateData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContrasenaHash", "Nombre", "Usuario" },
                values: new object[] { "guardia456", "Laura Gómez", "laurag" });
        }
    }
}
