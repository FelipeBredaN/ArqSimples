using TesteArq.Application.DTOs;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Interface
{
    public interface ICursoService
    {
        public Task<IEnumerable<CursoDTO>> GetAll();
        public Task<CursoDTO> GetById(int Id);
        public Task<CursoDTO> Add(CursoDTO cursoDto);
        public Task Update(CursoDTO cursoDto);
        public Task Delete(int Id);
         
    }
}