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
                throw ex;
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
                throw ex;
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }
    }
}
