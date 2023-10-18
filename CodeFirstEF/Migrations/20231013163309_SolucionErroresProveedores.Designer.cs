﻿// <auto-generated />
using System;
using CodeFirstEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstEF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231013163309_SolucionErroresProveedores")]
    partial class SolucionErroresProveedores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstEF.Models.Almacenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Almacenes");
                });

            modelBuilder.Entity("CodeFirstEF.Models.CategoriaProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("CategoriaProducto");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Ciudades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartamentosId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentosId");

                    b.ToTable("Ciudades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentosId = 2,
                            Estado = 0,
                            Nombre = "Rosario"
                        },
                        new
                        {
                            Id = 2,
                            DepartamentosId = 2,
                            Estado = 0,
                            Nombre = "Funes"
                        },
                        new
                        {
                            Id = 3,
                            DepartamentosId = 1,
                            Estado = 0,
                            Nombre = "Roldan"
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.Departamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ProvinciasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciasId");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = 0,
                            Nombre = "San Lorenzo",
                            ProvinciasId = 1
                        },
                        new
                        {
                            Id = 2,
                            Estado = 0,
                            Nombre = "Rosario",
                            ProvinciasId = 1
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.DetalleEntradaProductos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CodigoProducto")
                        .HasColumnType("int");

                    b.Property<int>("EncEntradaProductosId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioCompra")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EncEntradaProductosId");

                    b.ToTable("DetalleEntradaProductos");
                });

            modelBuilder.Entity("CodeFirstEF.Models.EncEntradaProductos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlmacenesId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Obsevaciones")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ProveedoresId")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TiposDocumentosEmitirId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AlmacenesId");

                    b.HasIndex("ProveedoresId");

                    b.HasIndex("TiposDocumentosEmitirId");

                    b.ToTable("EncEntradaProductos");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Marcas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcasId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("StockMax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("StockMin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnidadesDeMedidaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProductoId");

                    b.HasIndex("MarcasId");

                    b.HasIndex("UnidadesDeMedidaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CodeFirstEF.Models.ProveedorRubros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("ProveedorRubros");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Proveedores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<int>("CiudadesId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreachion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ProveedorRubrosId")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("SexoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadesId");

                    b.HasIndex("SexoId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Provincias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Provincias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = 0,
                            Nombre = "Santa Fe"
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.Sexo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sexo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Masculino",
                            Estado = 0
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Femenino",
                            Estado = 0
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Otro",
                            Estado = 0
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.StockProducto", b =>
                {
                    b.Property<int>("ProductosId")
                        .HasColumnType("int");

                    b.Property<int>("AlmacenesId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("StockInicial")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductosId", "AlmacenesId")
                        .HasName("PK_StockProducto");

                    b.HasIndex("AlmacenesId");

                    b.ToTable("StockProducto");
                });

            modelBuilder.Entity("CodeFirstEF.Models.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "DNI",
                            Estado = 0
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "CUIL",
                            Estado = 0
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "CUIT",
                            Estado = 0
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.TiposDocumentosEmitir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TiposDocumentosEmitir");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Factura A",
                            Estado = 0
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Factura B",
                            Estado = 0
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Factura C",
                            Estado = 0
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Presupuesto",
                            Estado = 0
                        });
                });

            modelBuilder.Entity("CodeFirstEF.Models.UnidadesDeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abrebiatura")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("UnidadesDeMedida");
                });

            modelBuilder.Entity("ProveedorRubrosProveedores", b =>
                {
                    b.Property<int>("ProveedorRubrosNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedoresId")
                        .HasColumnType("int");

                    b.HasKey("ProveedorRubrosNavigationId", "ProveedoresId");

                    b.HasIndex("ProveedoresId");

                    b.ToTable("ProveedorRubrosProveedores");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Ciudades", b =>
                {
                    b.HasOne("CodeFirstEF.Models.Departamentos", "DepartamentosNavigation")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartamentosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Departamentos", b =>
                {
                    b.HasOne("CodeFirstEF.Models.Provincias", "ProvinciasNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("ProvinciasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProvinciasNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.DetalleEntradaProductos", b =>
                {
                    b.HasOne("CodeFirstEF.Models.EncEntradaProductos", "EncEntradaProductosNavigation")
                        .WithMany("DetalleEntradaProductosNavigation")
                        .HasForeignKey("EncEntradaProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EncEntradaProductosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.EncEntradaProductos", b =>
                {
                    b.HasOne("CodeFirstEF.Models.Almacenes", "AlmacenesNavigation")
                        .WithMany("EncEntradaProductos")
                        .HasForeignKey("AlmacenesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.Proveedores", "ProveedoresNavigation")
                        .WithMany("EncEntradaProductos")
                        .HasForeignKey("ProveedoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.TiposDocumentosEmitir", "TiposDocumentosEmitirNavigation")
                        .WithMany("EncEntradaProductosNavigation")
                        .HasForeignKey("TiposDocumentosEmitirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlmacenesNavigation");

                    b.Navigation("ProveedoresNavigation");

                    b.Navigation("TiposDocumentosEmitirNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Productos", b =>
                {
                    b.HasOne("CodeFirstEF.Models.CategoriaProducto", "CategoriaProductoNavigation")
                        .WithMany("ProductosNavigation")
                        .HasForeignKey("CategoriaProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.Marcas", "MarcasNavigation")
                        .WithMany("ProductosNavigation")
                        .HasForeignKey("MarcasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.UnidadesDeMedida", "UnidadesDeMedidaNavigation")
                        .WithMany("ProductosNavigation")
                        .HasForeignKey("UnidadesDeMedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaProductoNavigation");

                    b.Navigation("MarcasNavigation");

                    b.Navigation("UnidadesDeMedidaNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Proveedores", b =>
                {
                    b.HasOne("CodeFirstEF.Models.Ciudades", "CiudadesNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("CiudadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.Sexo", "SexoNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("SexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.TipoDocumento", "TipoDocumentoNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CiudadesNavigation");

                    b.Navigation("SexoNavigation");

                    b.Navigation("TipoDocumentoNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.StockProducto", b =>
                {
                    b.HasOne("CodeFirstEF.Models.Almacenes", "AlmacenesNavigation")
                        .WithMany("StockProducto")
                        .HasForeignKey("AlmacenesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.Productos", null)
                        .WithMany("StockProducto")
                        .HasForeignKey("ProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlmacenesNavigation");
                });

            modelBuilder.Entity("ProveedorRubrosProveedores", b =>
                {
                    b.HasOne("CodeFirstEF.Models.ProveedorRubros", null)
                        .WithMany()
                        .HasForeignKey("ProveedorRubrosNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEF.Models.Proveedores", null)
                        .WithMany()
                        .HasForeignKey("ProveedoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstEF.Models.Almacenes", b =>
                {
                    b.Navigation("EncEntradaProductos");

                    b.Navigation("StockProducto");
                });

            modelBuilder.Entity("CodeFirstEF.Models.CategoriaProducto", b =>
                {
                    b.Navigation("ProductosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Ciudades", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Departamentos", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("CodeFirstEF.Models.EncEntradaProductos", b =>
                {
                    b.Navigation("DetalleEntradaProductosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Marcas", b =>
                {
                    b.Navigation("ProductosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Productos", b =>
                {
                    b.Navigation("StockProducto");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Proveedores", b =>
                {
                    b.Navigation("EncEntradaProductos");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Provincias", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("CodeFirstEF.Models.Sexo", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("CodeFirstEF.Models.TipoDocumento", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("CodeFirstEF.Models.TiposDocumentosEmitir", b =>
                {
                    b.Navigation("EncEntradaProductosNavigation");
                });

            modelBuilder.Entity("CodeFirstEF.Models.UnidadesDeMedida", b =>
                {
                    b.Navigation("ProductosNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
