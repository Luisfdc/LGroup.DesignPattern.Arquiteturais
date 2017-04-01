using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.DomainModels.Entities
{
    public class Professor
    {
        public Professor() { }
        public Professor(string nome)
        {
            this.Cursos = new List<Curso>();
            this.Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; private set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
