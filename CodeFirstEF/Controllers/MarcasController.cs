using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/marcas")]
    public class MarcasController : ControllerBase
    {
        public ApplicationDbContext context { get; }
        public IMapper mapper { get; }
        public MarcasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(MarcasCreacionDTO marcaCreacion)
        {
            var marca = mapper.Map<Marcas>(marcaCreacion);
            context.Add(marca);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varias marcas")]
        public async Task<ActionResult> Post(MarcasCreacionDTO[] marcasCreacion)
        {
            var marcas = mapper.Map<Marcas[]>(marcasCreacion);
            context.AddRange(marcas);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de marcas")]
        public async Task<ActionResult<IEnumerable<Marcas>>> Get()
        {
            return await context.Marcas.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<Marcas>>> Get(string nombre)
        {
            return await context.Marcas.Where(m => m.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, MarcasCreacionDTO marcaCreacionDTO)
        {
            var marca = mapper.Map<Marcas>(marcaCreacionDTO);
            marca.Id = id;
            context.Update(marca);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Marcas.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
