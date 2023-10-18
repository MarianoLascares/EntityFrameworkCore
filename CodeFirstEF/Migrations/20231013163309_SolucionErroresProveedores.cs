using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class SolucionErroresProveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_TipoDocumento_TipoDocumentoNavigationId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "Proveedores");

            migrationBuilder.RenameColumn(
                name: "TipoDocumentoNavigationId",
                table: "Proveedores",
                newName: "TipoDocumentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Proveedores_TipoDocumentoNavigationId",
                table: "Proveedores",
                newName: "IX_Proveedores_TipoDocumentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_TipoDocumento_TipoDocumentoId",
                table: "Proveedores",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_TipoDocumento_TipoDocumentoId",
                table: "Proveedores");

            migrationBuilder.RenameColumn(
                name: "TipoDocumentoId",
                table: "Proveedores",
                newName: "TipoDocumentoNavigationId");

            migrationBuilder.RenameIndex(
                name: "IX_Proveedores_TipoDocumentoId",
                table: "Proveedores",
                newName: "IX_Proveedores_TipoDocumentoNavigationId");

            migrationBuilder.AddColumn<int>(
                name: "TipoDocumento",
                table: "Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_TipoDocumento_TipoDocumentoNavigationId",
                table: "Proveedores",
                column: "TipoDocumentoNavigationId",
                principalTable: "TipoDocumento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
