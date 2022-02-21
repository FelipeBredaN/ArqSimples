using TesteArq.Domain.Entity;

namespace TesteArq.Application.Interface
{
    public interface IAlunoService
    {
        public Task<IEnumerable<Aluno>> GetAll();
        public Task<Aluno> GetById(int Id);
        public Task<Aluno> Add(Aluno aluno);
        public Task Update(Aluno aluno);
        public Task Delete(int Id);
    }
}
