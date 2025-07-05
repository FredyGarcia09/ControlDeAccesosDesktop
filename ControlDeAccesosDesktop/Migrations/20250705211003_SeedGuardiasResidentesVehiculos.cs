using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlDeAccesosDesktop.Migrations
{
    /// <inheritdoc />
    public partial class SeedGuardiasResidentesVehiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guardias",
                columns: new[] { "Id", "ContrasenaHash", "Nombre", "Usuario" },
                values: new object[,]
                {
                    { 1, "admin123", "Carlos Ramírez", "carlosr" },
                    { 2, "guardia456", "Laura Gómez", "laurag" }
                });

            migrationBuilder.InsertData(
                table: "Residentes",
                columns: new[] { "Id", "Apellidos", "ContrasenaHash", "Domicilio", "Foto", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Pérez", "res123", "Calle Robles 101", null, "Juan", "555-1001" },
                    { 2, "González", "res234", "Calle Encinos 202", null, "María", "555-1002" },
                    { 3, "Martínez", "res345", "Calle Ciprés 303", null, "Luis", "555-1003" },
                    { 4, "Rodríguez", "res456", "Calle Palmas 404", null, "Ana", "555-1004" },
                    { 5, "López", "res567", "Calle Sauces 505", null, "Pedro", "555-1005" }
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "Id", "Marca", "Modelo", "Placas", "ResidenteId" },
                values: new object[,]
                {
                    { 1, "Toyota", "Corolla", "ABC-123", 1 },
                    { 2, "Nissan", "Versa", "XYZ-456", 2 },
                    { 3, "Honda", "Civic", "JKL-789", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guardias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
