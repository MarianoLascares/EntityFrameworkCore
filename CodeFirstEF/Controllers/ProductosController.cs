using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/Productos")]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductosCreacionDTO productoCreacionDTO)
        {
            var producto = mapper.Map<Productos>(productoCreacionDTO);
            context.Add(producto);

            /*if (producto.MarcasNavigation is not null)
            {
                context.Entry(producto.MarcasNavigation).State = EntityState.Unchanged;
            }
            if (producto.UnidadesDeMedidaNavigation is not null)
            {
                context.Entry(producto.UnidadesDeMedidaNavigation).State = EntityState.Unchanged;
            }
            if (producto.CategoriaProductoNavigation is not null)
            {
                context.Entry(producto.CategoriaProductoNavigation).State = EntityState.Unchanged;
            }*/

            await context.SaveChangesAsync();
            return Ok(producto);
        }

        [HttpPost("Varios productos")]
        public async Task<ActionResult> Post(ProductosCreacionDTO[] productoCreacionDTO)
        {
            var productos = mapper.Map<Productos[]>(productoCreacionDTO);
            context.AddRange(productos);
            await context.SaveChangesAsync();
            return Ok(productos);
        }

        [HttpGet("Lista de Productos")]
        public async Task<ActionResult<IEnumerable<Productos>>> Get()
        {
            return await context.Productos.ToListAsync();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Productos.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
