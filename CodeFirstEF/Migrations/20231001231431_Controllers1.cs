using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class Controllers1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockActual",
                table: "StockProducto",
                newName: "StockInicial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockInicial",
                table: "StockProducto",
                newName: "StockActual");
        }
    }
}
