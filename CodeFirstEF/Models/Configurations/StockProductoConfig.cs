using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEF.Models.Configurations
{
    public class StockProductoConfig : IEntityTypeConfiguration<StockProducto>
    {
        public void Configure(EntityTypeBuilder<StockProducto> builder)
        {
            builder.HasKey(sp => new { sp.ProductosId, sp.AlmacenesId }).HasName("PK_StockProducto");
        }
    }
}
