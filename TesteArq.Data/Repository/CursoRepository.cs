using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly ProjDbContext _context;
        public CursoRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<Curso> Add(Curso curso)
        {
            await _context.AddAsync(curso);
            _context.SaveChanges();
            return curso;
        }

        public async Task Delete(int Id)
        {
            var curso = await _context.Curso.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(curso);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Curso>> GetAll()
        {
            var curso = await _context.Curso.ToListAsync();
            return curso;
        }

        public async Task<Curso> GetById(int Id)
        {
            var curso = await _context.Curso.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return curso;
        }

        public async Task Update(Curso curso)
        {
            _context.Curso.Update(curso);
            await _context.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<Curso>> FindBy(Expression<Func<Curso, bool>> predicate)
        {
            return await _context.Set<Curso>().Where(predicate).ToListAsync();
        }
    }
}