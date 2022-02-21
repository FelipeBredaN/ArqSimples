using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        public AlunoService(IAlunoRepository alunoRepository, ICursoRepository cursoRepository)
        {
            _alunoRepository = alunoRepository;
            _cursoRepository = cursoRepository;
        }
        public async Task<Aluno> Add(Aluno aluno)
        {
            var curso = await _cursoRepository.GetById(aluno.CursoId);
            if(curso == null)
                throw new Exception("Curso não existe");
            return await _alunoRepository.Add(aluno);
        }

        public async Task Delete(int Id)
        {
            await _alunoRepository.Delete(Id);
        }

        public async Task<IEnumerable<Aluno>> GetAll()
        {
            return await _alunoRepository.GetAll();
        }

        public async Task<Aluno> GetById(int Id)
        {
            return await _alunoRepository.GetById(Id);
        }

        public async Task Update(Aluno aluno)
        {
            var curso = await _cursoRepository.GetById(aluno.CursoId);
            if(curso == null)
                throw new Exception("Curso não existe");
            await _alunoRepository.Update(aluno);
        }
    }
}
