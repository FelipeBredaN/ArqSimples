using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IAlunoRepository
    {
        public Task<IEnumerable<Aluno>> GetAll();
        public Task<Aluno> GetById(int Id);
        public Task<Aluno> Add(Aluno aluno);
        public Task Update(Aluno aluno);
        public Task Delete(int Id);
    }
}
