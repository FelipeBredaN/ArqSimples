using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs
{
    public class AlunoDTO
    {
        public AlunoDTO(int matricula, string nome, int cursoId)
        {
            Matricula = matricula;
            Nome = nome;
            CursoId = cursoId;
        }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int CursoId { get; set; }
        public virtual Curso? Curso {get; set;}

    }
}