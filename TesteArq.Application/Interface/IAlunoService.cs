using TesteArq.Application.DTOs;

namespace TesteArq.Application.Interface
{
    public interface IAlunoService
    {
        public Task<IEnumerable<AlunoDTO>> GetAll();
        public Task<AlunoDTO> GetById(int Id);
        public Task<AlunoDTO> Add(AlunoDTO alunoDto);
        public Task Update(AlunoDTO alunoDto);
        public Task Delete(int Id);
    }
}
