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
    public class ProfessorRepository : IProfessorRepository
    {
        private List<DbContext> _context;
        public ProfessorRepository(List<DbContext> context)
        {
            _context = context;
        }
        public void Add(Professor aluno)
        {
            _context.ForEach(x =>
            {
                x.Set<Professor>().Add(aluno);
                x.SaveChanges();
            });
        }

        public IEnumerable<Professor> GetAll()
        {
            //Éobrigatório da o ToList()
            return _context[0].Set<Professor>().ToList();
        }
    }
}
