using AlunoFaculdadeCrud.Data;
using AlunoFaculdadeCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlunoFaculdadeCrud.Controllers
{
    [ApiController]
    public class CursoController : ControllerBase
    {
        [HttpGet("v1/cursos")]
        public async Task<IActionResult> GetAsync([FromServices] DataContext context)
            => Ok(await context.Cursos.ToListAsync());

        [HttpGet("v1/cursos/{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromServices] DataContext context)
        {
            var curso = await context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            if (curso == null) return NotFound("Curso não encontrado.");

            return Ok(curso);
        }

        [HttpPost("v1/cursos/cadastro")]
        public async Task<IActionResult> PostAsync([FromBody] CursoModel curso, [FromServices] DataContext context)
        {
            await context.Cursos.AddAsync(curso);
            await context.SaveChangesAsync();

            return Created($"v1/cursos/cadastro/{curso.Id}", "Curso cadastrado com sucesso.");
        }

        [HttpPut("v1/cursos/atualizar/{id:int}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] CursoModel curso, [FromServices] DataContext context)
        {
            var model = await context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null) return NotFound("Curso não encontrado.");

            model.Nome = curso.Nome;

            context.Cursos.Update(model);
            await context.SaveChangesAsync();

            return Ok("Curso atualizado com sucesso.");
        }

        [HttpDelete("v1/cursos/deletar/{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id, [FromServices] DataContext context)
        {
            var model = await context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null) return NotFound("Curso não encontrado.");

            context.Cursos.Remove(model);
            await context.SaveChangesAsync();

            return Ok("Curso deletado com sucesso.");
        }
    }
}
