using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        public readonly ICursoService _cursoService;
        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }
         // GET: api/<CursoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoDTO>>> Get()
        {
            return Ok(await _cursoService.GetAll());
        }

        // GET api/<CursoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDTO>> Get(int id)
        {
            return Ok(await _cursoService.GetById(id));
        }

        // POST api/<CursoController>
        [HttpPost]
        public async Task<ActionResult<CursoDTO>> Post([FromBody] CursoDTO curso)
        {
            return Ok(await _cursoService.Add(curso));
        }

        // PUT api/<CursoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CursoDTO curso)
        {
            await _cursoService.Update(curso);
            return Ok();
        }

        // DELETE api/<CursoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _cursoService.Delete(id);
            return Ok();
        }
        
    }
}