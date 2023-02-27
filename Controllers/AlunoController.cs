using AlunoFaculdadeCrud.Data;
using AlunoFaculdadeCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlunoFaculdadeCrud.Controllers
{
    [ApiController]
    public class AlunoController : ControllerBase
    {
        [HttpGet("v1/alunos")]
        public async Task<IActionResult> GetAsync([FromServices] DataContext context)
            => Ok(await context.Alunos.ToListAsync());

        [HttpGet("v1/alunos/{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromServices] DataContext context)
        {
            var aluno = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);
            if (aluno == null) return NotFound("Aluno não encontrado.");

            return Ok(aluno);
        }

        [HttpPost("v1/alunos/cadastro")]
        public async Task<IActionResult> PostAsync([FromBody] AlunoModel aluno, [FromServices] DataContext context)
        {
            await context.Alunos.AddAsync(aluno);
            await context.SaveChangesAsync();

            return Created($"v1/alunos/cadastro/{aluno.Id}", "Aluno cadastrado com sucesso.");
        }

        [HttpPut("v1/alunos/atualizar/{id:int}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] AlunoModel aluno, [FromServices] DataContext context)
        {
            var model = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null) return NotFound("Aluno não encontrado.");

            model.Nome = aluno.Nome;
            model.Email = aluno.Email;
            model.Curso = aluno.Curso;
            model.Turno = aluno.Turno;

            context.Alunos.Update(model);
            await context.SaveChangesAsync();

            return Ok("Aluno atualizado com sucesso.");
        }

        [HttpDelete("v1/alunos/deletar/{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id, [FromServices] DataContext context)
        {
            var model = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null) return NotFound("Aluno não encontrado.");

            context.Alunos.Remove(model);
            await context.SaveChangesAsync();

            return Ok("Aluno deletado com sucesso.");
        }
    }
}
