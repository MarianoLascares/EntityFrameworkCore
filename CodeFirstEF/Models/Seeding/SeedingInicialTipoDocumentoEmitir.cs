using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Models.Seeding
{
    public class SeedingInicialTipoDocumentoEmitir
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            TiposDocumentosEmitir FacturaA = new TiposDocumentosEmitir()
            {
                Id = 1,
                Descripcion = "Factura A"
            };

            TiposDocumentosEmitir FacturaB = new TiposDocumentosEmitir()
            {
                Id = 2,
                Descripcion = "Factura B"
            };

            TiposDocumentosEmitir FacturaC = new TiposDocumentosEmitir()
            {
                Id = 3,
                Descripcion = "Factura C"
            };

            TiposDocumentosEmitir Presupuesto = new TiposDocumentosEmitir()
            {
                Id = 4,
                Descripcion = "Presupuesto"
            };

            modelBuilder.Entity<TiposDocumentosEmitir>().HasData(FacturaA, FacturaB, FacturaC, Presupuesto);
        }
    }
}
