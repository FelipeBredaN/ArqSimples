using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<Aluno> AddAluno(Aluno aluno)
        {
            return await _alunoRepository.AddAluno(aluno);
        }

        public async Task DeleteAluno(int Id)
        {
            await _alunoRepository.DeleteAluno(Id);
        }

        public Task<IEnumerable<Aluno>> GetAll()
        {
            return _alunoRepository.GetAll();
        }

        public async Task<Aluno> GetById(int Id)
        {
            return await _alunoRepository.GetById(Id);
        }

        public async Task UpdateAluno(Aluno aluno)
        {
            await _alunoRepository.UpdateAluno(aluno);
        }
    }
}
