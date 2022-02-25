using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;

        public AlunoService(IAlunoRepository alunoRepository, ICursoRepository cursoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }
        public async Task<AlunoDTO> Add(AlunoDTO alunoDto)
        {
            var curso = await _cursoRepository.GetById(alunoDto.CursoId);
            if(curso == null)
                throw new Exception("Curso não existe");
            var alunoEntity = _mapper.Map<Aluno>(alunoDto);
            await _alunoRepository.Add(alunoEntity);
            return alunoDto;
        }

        public async Task Delete(int Id)
        {
            await _alunoRepository.Delete(Id);
        }

        public async Task<IEnumerable<AlunoDTO>> GetAll()
        {
            var alunoEntity = await _alunoRepository.GetAll();
            return _mapper.Map<IEnumerable<AlunoDTO>>(alunoEntity);
        }

        public async Task<AlunoDTO> GetById(int Id)
        {
            var alunoEntity = await _alunoRepository.GetById(Id);
            return _mapper.Map<AlunoDTO>(alunoEntity);
        }

        public async Task Update(AlunoDTO alunoDto)
        {
            var curso = await _cursoRepository.GetById(alunoDto.CursoId);
            if(curso == null)
                throw new Exception("Curso não existe");
            var alunoEntity = _mapper.Map<Aluno>(alunoDto);
            await _alunoRepository.Update(alunoEntity);
        }
    }
}
