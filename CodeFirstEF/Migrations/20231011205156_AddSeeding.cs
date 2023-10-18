using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "Estado", "Nombre" },
                values: new object[] { 1, 0, "Santa Fe" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Estado", "Nombre", "ProvinciasId" },
                values: new object[,]
                {
                    { 1, 0, "San Lorenzo", 1 },
                    { 2, 0, "Rosario", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "DepartamentosId", "Estado", "Nombre" },
                values: new object[,]
                {
                    { 1, 2, 0, "Rosario" },
                    { 2, 2, 0, "Funes" },
                    { 3, 1, 0, "Roldan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
