using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/Categoria Producto")]
    public class CategoriaProductoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriaProductoController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CategoriaProductoCreacionDTO categoriaProductoDTO)
        {
            var categoria = mapper.Map<CategoriaProducto>(categoriaProductoDTO);
            context.Add(categoria);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varias Unidades")]
        public async Task<ActionResult> Post(CategoriaProductoCreacionDTO[] categoriaProductoDTO)
        {
            var categorias = mapper.Map<CategoriaProducto[]>(categoriaProductoDTO);
            context.AddRange(categorias);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de Categorias")]
        public async Task<ActionResult<IEnumerable<CategoriaProducto>>> Get()
        {
            return await context.CategoriaProducto.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<CategoriaProducto>>> Get(string nombre)
        {
            return await context.CategoriaProducto.Where(c => c.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, CategoriaProductoCreacionDTO categoriasCreacionDTO)
        {
            var categoria = mapper.Map<CategoriaProducto>(categoriasCreacionDTO);
            categoria.Id = id;
            context.Update(categoria);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.CategoriaProducto.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
