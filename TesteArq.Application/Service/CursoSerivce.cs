using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class CursoSerivce : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoSerivce(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public async Task<Curso> Add(Curso curso)
        {
            return await _cursoRepository.Add(curso);
        }

        public async Task Delete(int Id)
        {
            await _cursoRepository.Delete(Id);
        }

        public async Task<IEnumerable<Curso>> GetAll()
        {
            return await _cursoRepository.GetAll();

        }

        public async Task<Curso> GetById(int Id)
        {
            return await _cursoRepository.GetById(Id);

        }

        public async Task Update(Curso curso)
        {
            await _cursoRepository.Update(curso);

        }
    }
}