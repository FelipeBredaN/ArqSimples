using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<Curso>>> Get()
        {
            try
            {
                return Ok(await _cursoService.GetAll());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<CursoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> Get(int id)
        {
            try
            {
                return Ok(await _cursoService.GetById(id));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<CursoController>
        [HttpPost]
        public async Task<ActionResult<Curso>> Post([FromBody] Curso curso)
        {
            try
            {
                return Ok(await _cursoService.Add(curso));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<CursoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Curso curso)
        {
            try
            {
                await _cursoService.Update(curso);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<CursoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _cursoService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
    }
}