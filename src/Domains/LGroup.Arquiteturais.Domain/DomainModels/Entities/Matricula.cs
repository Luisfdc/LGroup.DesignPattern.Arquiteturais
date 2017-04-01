using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.DomainModels.Entities
{
    public class Matricula
    {
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public Aluno Aluno { get; set; }
    }
}
