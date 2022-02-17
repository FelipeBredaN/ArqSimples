using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IAlunoRepository
    {
        public Task<IEnumerable<Aluno>> GetAll();
        public Task<Aluno> GetById(int Id);
        public Task<Aluno> AddAluno(Aluno aluno);
        public Task UpdateAluno(Aluno aluno);
        public Task DeleteAluno(int Id);
    }
}
