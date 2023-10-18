using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDocumentosEmitir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TiposDocumentosEmitir",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "Factura A", 0 },
                    { 2, "Factura B", 0 },
                    { 3, "Factura C", 0 },
                    { 4, "Presupuesto", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposDocumentosEmitir",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDocumentosEmitir",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDocumentosEmitir",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposDocumentosEmitir",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
