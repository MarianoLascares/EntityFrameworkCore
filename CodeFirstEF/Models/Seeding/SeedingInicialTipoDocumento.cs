using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Models.Seeding
{
    public class SeedingInicialTipoDocumento
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            TipoDocumento Dni = new TipoDocumento()
            {
                Id = 1,
                Descripcion = "DNI"
            };

            TipoDocumento Cuil = new TipoDocumento()
            {
                Id = 2,
                Descripcion = "CUIL"
            };

            TipoDocumento Cuit = new TipoDocumento()
            {
                Id = 3,
                Descripcion = "CUIT"
            };

            modelBuilder.Entity<TipoDocumento>().HasData(Dni, Cuil, Cuit);
        }
    }
}
