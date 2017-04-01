using LGroup.Arquiteturais.Domain.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Data.Contexts
{
    public class ContextInterno : DbContext
    {
        public ContextInterno()
            : base("ConexaoInterno")
        { }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
    }
}
