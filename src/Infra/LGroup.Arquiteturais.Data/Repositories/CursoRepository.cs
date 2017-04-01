using LGroup.Arquiteturais.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Arquiteturais.Domain.DomainModels.Entities;
using System.Data.Entity;

namespace LGroup.Arquiteturais.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private List<DbContext> _context;
        public CursoRepository(List<DbContext> context)
        {
            _context = context;
        }
        public void Add(Curso aluno)
        {
            _context.ForEach(x =>
            {
                x.Set<Curso>().Add(aluno);
                x.SaveChanges();
            });
        }

        public IEnumerable<Curso> GetAll()
        {
            //Éobrigatório da o ToList()
            return _context[0].Set<Curso>().ToList();
        }
    }
}
