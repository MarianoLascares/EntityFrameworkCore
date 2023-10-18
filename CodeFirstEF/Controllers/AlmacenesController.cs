using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/Almacenes")]
    public class AlmacenesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AlmacenesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AlmacenesCreacionDTO almacenCreacionDTO)
        {
            var almacen = mapper.Map<Almacenes>(almacenCreacionDTO);
            context.Add(almacen);
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("Varios Almacenes")]
        public async Task<ActionResult> Post(AlmacenesCreacionDTO[] almacenCreacionDTO)
        {
            var almacenes = mapper.Map<Almacenes[]>(almacenCreacionDTO);
            context.AddRange(almacenes);
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("Lista de Almacenes")]
        public async Task<ActionResult<IEnumerable<Almacenes>>> Get()
        {
            return await context.Almacenes.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<Almacenes>>> Get(string nombre)
        {
            return await context.Almacenes.Where(c => c.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("Agregar Productos en almacen {id:int}")]
        public async Task<ActionResult> Put(int id, AlmacenesCreacionDTO almacenCreacionDTO)
        {
            var almacen = mapper.Map<Almacenes>(almacenCreacionDTO);
            almacen.Id = id;
            context.Update(almacen);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Almacenes.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
