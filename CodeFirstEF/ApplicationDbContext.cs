using CodeFirstEF.Models;
using CodeFirstEF.Models.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CodeFirstEF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingInicialSexo.Seed(modelBuilder);
            SeedingInicialTipoDocumento.Seed(modelBuilder);
            SeedingInicialUbicacion.Seed(modelBuilder);
            SeedingInicialTipoDocumentoEmitir.Seed(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        public DbSet<Almacenes> Almacenes => Set<Almacenes>();
        public DbSet<Productos> Productos => Set<Productos>();
        public DbSet<Marcas> Marcas => Set<Marcas>();
        public DbSet<CategoriaProducto> CategoriaProducto => Set<CategoriaProducto>();
        public DbSet<StockProducto> StockProducto => Set<StockProducto>();
        public DbSet<UnidadesDeMedida> UnidadesDeMedida => Set<UnidadesDeMedida>();
        public DbSet<Provincias> Provincias => Set<Provincias>();
        public DbSet<Departamentos> Departamentos => Set<Departamentos>();
        public DbSet<Ciudades> Ciudades => Set<Ciudades>();
        public DbSet<Proveedores> Proveedores => Set<Proveedores>();
        public DbSet<TipoDocumento> TipoDocumento => Set<TipoDocumento>();
        public DbSet<Sexo> Sexo => Set<Sexo>();
        public DbSet<ProveedorRubros> ProveedorRubros => Set<ProveedorRubros>();
        public DbSet<TiposDocumentosEmitir> TiposDocumentosEmitir => Set<TiposDocumentosEmitir>();
        public DbSet<DetalleEntradaProductos> DetalleEntradaProductos => Set<DetalleEntradaProductos>();
        public DbSet<EncEntradaProductos> EncEntradaProductos=> Set<EncEntradaProductos>();
    }
}
