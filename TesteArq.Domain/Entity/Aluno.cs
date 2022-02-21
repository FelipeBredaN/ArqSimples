using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArq.Domain.Entity
{
    public class Aluno : BaseEntity
    {
        public Aluno(int matricula, string nome, int cursoId)
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
