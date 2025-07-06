using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlDeAccesosDesktop.Migrations
{
    /// <inheritdoc />
    public partial class SeAgregoElQRParaResidentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoQR",
                table: "Residentes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CodigoQR",
                value: "RES001");

            migrationBuilder.UpdateData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CodigoQR",
                value: "RES002");

            migrationBuilder.UpdateData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CodigoQR",
                value: "RES003");

            migrationBuilder.UpdateData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CodigoQR",
                value: "RES004");

            migrationBuilder.UpdateData(
                table: "Residentes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CodigoQR",
                value: "RES005");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoQR",
                table: "Residentes");
        }
    }
}
