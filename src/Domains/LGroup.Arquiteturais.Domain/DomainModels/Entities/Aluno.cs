using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.DomainModels.Entities
{
    public class Aluno
    {
        private Aluno()
        {

        }
        public Aluno(string nome)
        {
            Cursos = new Collection<Curso>();
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
