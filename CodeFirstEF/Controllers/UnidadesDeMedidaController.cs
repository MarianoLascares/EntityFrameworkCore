using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/Unidades De Medida")]
    public class UnidadesDeMedidaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UnidadesDeMedidaController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(UnidadesDeMedidaCreacionDTO unidadCreacion)
        {
            var unidad = mapper.Map<UnidadesDeMedida>(unidadCreacion);
            context.Add(unidad);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varias Unidades")]
        public async Task<ActionResult> Post(UnidadesDeMedidaCreacionDTO[] unidadesCreacion)
        {
            var unidades = mapper.Map<UnidadesDeMedida[]>(unidadesCreacion);
            context.AddRange(unidades);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de Unidades de medida")]
        public async Task<ActionResult<IEnumerable<UnidadesDeMedida>>> Get()
        {
            return await context.UnidadesDeMedida.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<UnidadesDeMedida>>> Get(string nombre)
        {
            return await context.UnidadesDeMedida.Where(um => um.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, UnidadesDeMedidaCreacionDTO unidadesCreacionDTO)
        {
            var unidad = mapper.Map<UnidadesDeMedida>(unidadesCreacionDTO);
            unidad.Id = id;
            context.Update(unidad);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.UnidadesDeMedida.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
