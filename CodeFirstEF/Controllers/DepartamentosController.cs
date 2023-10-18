using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Controllers
{
    [ApiController]
    [Route("api/departamentos")]
    public class DepartamentosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public DepartamentosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(DepartamentosCreacionDTO departamentoCreacion)
        {
            var departamento = mapper.Map<Departamentos>(departamentoCreacion);
            context.Add(departamento);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Varios departamentos")]
        public async Task<ActionResult> Post(DepartamentosCreacionDTO[] departamentosCreacionDTO)
        {
            var departamentos = mapper.Map<Departamentos[]>(departamentosCreacionDTO);
            context.AddRange(departamentos);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Lista de departamentos")]
        public async Task<ActionResult<IEnumerable<Departamentos>>> Get()
        {
            return await context.Departamentos.ToListAsync();
        }

        [HttpGet("Busqueda por nombre")]
        public async Task<ActionResult<IEnumerable<Departamentos>>> Get(string nombre)
        {
            return await context.Departamentos.Where(m => m.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, DepartamentosCreacionDTO departamentoCreacionDTO)
        {
            var departamento = mapper.Map<Departamentos>(departamentoCreacionDTO);
            departamento.Id = id;
            context.Update(departamento);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Departamentos.Where(_ => _.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
