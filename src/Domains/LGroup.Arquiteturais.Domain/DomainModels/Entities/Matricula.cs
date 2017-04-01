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

        //Para habilitar o lazyload temos que colocar o virtual na propriedade
        //Também temos que referencia um identificador para a forigninkey
        public int IdCurso { get; set; }
        public virtual Curso Curso { get; set; }
        public int IdAluno { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
