using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ProjDbContext _context;
        public AlunoRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<Aluno> Add(Aluno aluno)
        {
            await _context.AddAsync(aluno);
            _context.SaveChanges();
            return aluno;
        }

        public async Task Delete(int Id)
        {
            var aluno = await _context.Aluno.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aluno>> GetAll()
        {
            var alunos = await _context.Aluno.ToListAsync();
            return alunos;
        }

        public async Task<Aluno> GetById(int Id)
        {
            var aluno = await _context.Aluno.Where(x => x.Id == Id).Include(x => x.Curso).FirstOrDefaultAsync();
            return aluno;
        }

        public async Task Update(Aluno aluno)
        {
            _context.Aluno.Update(aluno);
            await _context.SaveChangesAsync();
        }
    }
}
