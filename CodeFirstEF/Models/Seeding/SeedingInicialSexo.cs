using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Models.Seeding
{
    public class SeedingInicialSexo
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            Sexo Masculino = new Sexo()
            {
                Id = 1,
                Descripcion = "Masculino"
            };

            Sexo Femenino = new Sexo()
            {
                Id = 2,
                Descripcion = "Femenino"
            };

            Sexo Otro = new Sexo()
            {
                Id = 3,
                Descripcion = "Otro"
            };

            modelBuilder.Entity<Sexo>().HasData(Masculino, Femenino, Otro);
        }
    }
}
