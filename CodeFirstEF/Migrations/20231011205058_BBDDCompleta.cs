using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class BBDDCompleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_UnidadesDeMedida_UnidadesdeMedidaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_StockProducto_Almacenes_AlmacenesID",
                table: "StockProducto");

            migrationBuilder.RenameColumn(
                name: "AlmacenesID",
                table: "StockProducto",
                newName: "AlmacenesId");

            migrationBuilder.RenameIndex(
                name: "IX_StockProducto_AlmacenesID",
                table: "StockProducto",
                newName: "IX_StockProducto_AlmacenesId");

            migrationBuilder.RenameColumn(
                name: "UnidadesdeMedidaId",
                table: "Productos",
                newName: "UnidadesDeMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_UnidadesdeMedidaId",
                table: "Productos",
                newName: "IX_Productos_UnidadesDeMedidaId");

            migrationBuilder.CreateTable(
                name: "ProveedorRubros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorRubros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumentosEmitir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentosEmitir", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    ProvinciasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Provincias_ProvinciasId",
                        column: x => x.ProvinciasId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    DepartamentosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudades_Departamentos_DepartamentosId",
                        column: x => x.DepartamentosId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FechaCreachion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoNavigationId = table.Column<int>(type: "int", nullable: false),
                    ProveedorRubrosId = table.Column<int>(type: "int", nullable: false),
                    SexoId = table.Column<int>(type: "int", nullable: false),
                    CiudadesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Ciudades_CiudadesId",
                        column: x => x.CiudadesId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_TipoDocumento_TipoDocumentoNavigationId",
                        column: x => x.TipoDocumentoNavigationId,
                        principalTable: "TipoDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EncEntradaProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Obsevaciones = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    TiposDocumentosEmitirId = table.Column<int>(type: "int", nullable: false),
                    AlmacenesId = table.Column<int>(type: "int", nullable: false),
                    ProveedoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncEntradaProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncEntradaProductos_Almacenes_AlmacenesId",
                        column: x => x.AlmacenesId,
                        principalTable: "Almacenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncEntradaProductos_Proveedores_ProveedoresId",
                        column: x => x.ProveedoresId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncEntradaProductos_TiposDocumentosEmitir_TiposDocumentosEmitirId",
                        column: x => x.TiposDocumentosEmitirId,
                        principalTable: "TiposDocumentosEmitir",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedorRubrosProveedores",
                columns: table => new
                {
                    ProveedorRubrosNavigationId = table.Column<int>(type: "int", nullable: false),
                    ProveedoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorRubrosProveedores", x => new { x.ProveedorRubrosNavigationId, x.ProveedoresId });
                    table.ForeignKey(
                        name: "FK_ProveedorRubrosProveedores_ProveedorRubros_ProveedorRubrosNavigationId",
                        column: x => x.ProveedorRubrosNavigationId,
                        principalTable: "ProveedorRubros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProveedorRubrosProveedores_Proveedores_ProveedoresId",
                        column: x => x.ProveedoresId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleEntradaProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EncEntradaProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleEntradaProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleEntradaProductos_EncEntradaProductos_EncEntradaProductosId",
                        column: x => x.EncEntradaProductosId,
                        principalTable: "EncEntradaProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sexo",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "Masculino", 0 },
                    { 2, "Femenino", 0 },
                    { 3, "Otro", 0 }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumento",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "DNI", 0 },
                    { 2, "CUIL", 0 },
                    { 3, "CUIT", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentosId",
                table: "Ciudades",
                column: "DepartamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_ProvinciasId",
                table: "Departamentos",
                column: "ProvinciasId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEntradaProductos_EncEntradaProductosId",
                table: "DetalleEntradaProductos",
                column: "EncEntradaProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_EncEntradaProductos_AlmacenesId",
                table: "EncEntradaProductos",
                column: "AlmacenesId");

            migrationBuilder.CreateIndex(
                name: "IX_EncEntradaProductos_ProveedoresId",
                table: "EncEntradaProductos",
                column: "ProveedoresId");

            migrationBuilder.CreateIndex(
                name: "IX_EncEntradaProductos_TiposDocumentosEmitirId",
                table: "EncEntradaProductos",
                column: "TiposDocumentosEmitirId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_CiudadesId",
                table: "Proveedores",
                column: "CiudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_SexoId",
                table: "Proveedores",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoDocumentoNavigationId",
                table: "Proveedores",
                column: "TipoDocumentoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorRubrosProveedores_ProveedoresId",
                table: "ProveedorRubrosProveedores",
                column: "ProveedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_UnidadesDeMedida_UnidadesDeMedidaId",
                table: "Productos",
                column: "UnidadesDeMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockProducto_Almacenes_AlmacenesId",
                table: "StockProducto",
                column: "AlmacenesId",
                principalTable: "Almacenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_UnidadesDeMedida_UnidadesDeMedidaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_StockProducto_Almacenes_AlmacenesId",
                table: "StockProducto");

            migrationBuilder.DropTable(
                name: "DetalleEntradaProductos");

            migrationBuilder.DropTable(
                name: "ProveedorRubrosProveedores");

            migrationBuilder.DropTable(
                name: "EncEntradaProductos");

            migrationBuilder.DropTable(
                name: "ProveedorRubros");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "TiposDocumentosEmitir");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.RenameColumn(
                name: "AlmacenesId",
                table: "StockProducto",
                newName: "AlmacenesID");

            migrationBuilder.RenameIndex(
                name: "IX_StockProducto_AlmacenesId",
                table: "StockProducto",
                newName: "IX_StockProducto_AlmacenesID");

            migrationBuilder.RenameColumn(
                name: "UnidadesDeMedidaId",
                table: "Productos",
                newName: "UnidadesdeMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_UnidadesDeMedidaId",
                table: "Productos",
                newName: "IX_Productos_UnidadesdeMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_UnidadesDeMedida_UnidadesdeMedidaId",
                table: "Productos",
                column: "UnidadesdeMedidaId",
                principalTable: "UnidadesDeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockProducto_Almacenes_AlmacenesID",
                table: "StockProducto",
                column: "AlmacenesID",
                principalTable: "Almacenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
