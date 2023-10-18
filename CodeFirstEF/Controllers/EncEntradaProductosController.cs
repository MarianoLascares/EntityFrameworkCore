using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/Facturacion")]
    public class EncEntradaProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EncEntradaProductosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(EncEntradaProductosDTO EncEntradaProductosDTO)
        {
            var facturacion = mapper.Map<EncEntradaProductos>(EncEntradaProductosDTO);

            foreach (var detalle in facturacion.DetalleEntradaProductosNavigation)
            {
                detalle.Total = detalle.PrecioCompra * detalle.Cantidad;
                facturacion.Subtotal += detalle.Total;
                facturacion.Iva += (facturacion.Subtotal * 0.21m);

                var stockProducto = context.StockProducto.FirstOrDefault(
                    sp => sp.ProductosId == detalle.CodigoProducto && sp.AlmacenesId == facturacion.AlmacenesId
                    );

                if (stockProducto != null)
                {
                    stockProducto.StockInicial += detalle.Cantidad;
                    stockProducto.PrecioUnitario = detalle.PrecioCompra;
                }
            }
            facturacion.Total = facturacion.Subtotal + facturacion.Iva;

            context.Add(facturacion);
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("Lista de Facturas")]
        public async Task<ActionResult<IEnumerable<EncEntradaProductos>>> Get()
        {
            return await context.EncEntradaProductos.ToListAsync();
        }

        [HttpGet("Busqueda por Numero de Factura")]
        public async Task<ActionResult<IEnumerable<EncEntradaProductos>>> Get(int numFactura)
        {
            return await context.EncEntradaProductos.Where(m => m.Id == numFactura).ToListAsync();
        }
    }
}
