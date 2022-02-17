using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArq.Domain.Entity
{
    public class Aluno : BaseEntity
    {
        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
        public int Matricula { get; set; }
        public string Nome { get; set; }
    }
}
