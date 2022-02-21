using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface ICursoRepository
    {
        public Task<IEnumerable<Curso>> GetAll();
        public Task<Curso> GetById(int Id);
        public Task<Curso> Add(Curso curso);
        public Task Update(Curso curso);
        public Task Delete(int Id);
    }
}
