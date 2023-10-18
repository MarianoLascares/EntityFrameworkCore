using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/provincias")]
    public class ProvinciasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProvinciasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProvinciasCreacionDTO provinciasCreacion)
        {
            var provincia = mapper.Map<Provincias>(provinciasCreacion);
            context.Add(provincia);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varias provincias")]
        public async Task<ActionResult> Post(ProvinciasCreacionDTO[] provinciasCreacion)
        {
            var provincias = mapper.Map<Provincias[]>(provinciasCreacion);
            context.AddRange(provincias);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de provincias")]
        public async Task<ActionResult<IEnumerable<Provincias>>> Get()
        {
            return await context.Provincias.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<Provincias>>> Get(string nombre)
        {
            return await context.Provincias.Where(m => m.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, ProvinciasCreacionDTO provinciaCreacionDTO)
        {
            var provincia = mapper.Map<Provincias>(provinciaCreacionDTO);
            provincia.Id = id;
            context.Update(provincia);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Provincias.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
