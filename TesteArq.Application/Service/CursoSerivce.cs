using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class CursoSerivce : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;

        public CursoSerivce(ICursoRepository cursoRepository, IMapper mapper)
        {
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }
        public async Task<CursoDTO> Add(CursoDTO cursoDto)
        {
            var cursoEntity = _mapper.Map<Curso>(cursoDto);
            await _cursoRepository.Add(cursoEntity);
            return cursoDto;
        }

        public async Task Delete(int Id)
        {
            await _cursoRepository.Delete(Id);
        }

        public async Task<IEnumerable<CursoDTO>> GetAll()
        {
            var cursoEntity = await _cursoRepository.GetAll();
            return _mapper.Map<IEnumerable<CursoDTO>>(cursoEntity);

        }

        public async Task<CursoDTO> GetById(int Id)
        {
            var cursoEntity = await _cursoRepository.GetById(Id);
            return _mapper.Map<CursoDTO>(cursoEntity);
        }

        public async Task Update(CursoDTO curso)
        {
            var cursoEntity = _mapper.Map<Curso>(curso);
            await _cursoRepository.Update(cursoEntity);

        }
    }
}