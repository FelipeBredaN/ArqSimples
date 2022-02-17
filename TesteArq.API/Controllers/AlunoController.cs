using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }
        // GET: api/<AlunoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> Get()
        {
            try
            {
                return Ok(await _alunoService.GetAll());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro Inesperado");
            }
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> Get(int id)
        {
            try
            {
                return Ok(await _alunoService.GetById(id));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro Inesperado");
            }
        }

        // POST api/<AlunoController>
        [HttpPost]
        public async Task<ActionResult<Aluno>> Post([FromBody] Aluno aluno)
        {
            try
            {
                return Ok(await _alunoService.AddAluno(aluno));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro Inesperado");
            }
        }

        // PUT api/<AlunoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Aluno aluno)
        {
            try
            {
                await _alunoService.UpdateAluno(aluno);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro Inesperado");
            }
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _alunoService.DeleteAluno(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro Inesperado");
            }
        }
    }
}
