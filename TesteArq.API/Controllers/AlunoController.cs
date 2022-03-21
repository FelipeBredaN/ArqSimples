using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs;
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
        public async Task<ActionResult<IEnumerable<AlunoDTO>>> Get()
        {
            return Ok(await _alunoService.GetAll());
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoDTO>> Get(int id)
        {
            return Ok(await _alunoService.GetById(id));
        }

        // POST api/<AlunoController>
        [HttpPost]
        public async Task<ActionResult<AlunoDTO>> Post([FromBody] AlunoDTO aluno)
        {
            return Ok(await _alunoService.Add(aluno));
        }

        // PUT api/<AlunoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] AlunoDTO aluno)
        {
            await _alunoService.Update(aluno);
            return Ok();
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _alunoService.Delete(id);
            return Ok();
        }
    }
}
