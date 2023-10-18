using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Models.Seeding
{
    public class SeedingInicialUbicacion
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            Provincias SantaFe = new Provincias()
            {
                Id = 1,
                Nombre = "Santa Fe"
            };

            modelBuilder.Entity<Provincias>().HasData(SantaFe);

            Departamentos SanLorenzo = new Departamentos()
            {
                Id = 1,
                Nombre = "San Lorenzo",
                ProvinciasId = SantaFe.Id
            };

            Departamentos Rosario = new Departamentos()
            {
                Id = 2,
                Nombre = "Rosario",
                ProvinciasId = SantaFe.Id
            };

            modelBuilder.Entity<Departamentos>().HasData(SanLorenzo, Rosario);

            Ciudades RosarioCiudad = new Ciudades()
            {
                Id = 1,
                Nombre = "Rosario",
                DepartamentosId = Rosario.Id
            };

            Ciudades Funes = new Ciudades()
            {
                Id = 2,
                Nombre = "Funes",
                DepartamentosId = Rosario.Id
            };

            Ciudades Roldan = new Ciudades()
            {
                Id = 3,
                Nombre = "Roldan",
                DepartamentosId = SanLorenzo.Id
            };

            modelBuilder.Entity<Ciudades>().HasData(RosarioCiudad, Funes, Roldan);
        }
    }
}
