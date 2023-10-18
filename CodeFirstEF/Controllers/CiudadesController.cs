using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/ciudades")]
    public class CiudadesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CiudadesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CiudadesCreacionDTO ciudadesCreacionDTO)
        {
            var ciudad = mapper.Map<Ciudades>(ciudadesCreacionDTO);
            context.Add(ciudad);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varias ciudades")]
        public async Task<ActionResult> Post(CiudadesCreacionDTO[] ciudadesCreacionDTO)
        {
            var ciudades = mapper.Map<Ciudades[]>(ciudadesCreacionDTO);
            context.AddRange(ciudades);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de ciudades")]
        public async Task<ActionResult<IEnumerable<Ciudades>>> Get()
        {
            return await context.Ciudades.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<Ciudades>>> Get(string nombre)
        {
            return await context.Ciudades.Where(m => m.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, CiudadesCreacionDTO ciudadCreacionDTO)
        {
            var ciudad = mapper.Map<Ciudades>(ciudadCreacionDTO);
            ciudad.Id = id;
            context.Update(ciudad);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Ciudades.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
