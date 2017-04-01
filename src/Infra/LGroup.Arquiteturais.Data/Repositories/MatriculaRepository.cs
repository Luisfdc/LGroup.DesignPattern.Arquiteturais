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
    public class MatriculaRepository : IMatriculaRepository
    {
        private List<DbContext> _context;
        public MatriculaRepository(List<DbContext> context)
        {
            _context = context;
        }
        public void Add(Matricula aluno)
        {
            _context.ForEach(x =>
            {
                x.Set<Matricula>().Add(aluno);
                x.SaveChanges();
            });
        }

        public IEnumerable<Matricula> GetAll()
        {
            //Éobrigatório da o ToList()
            return _context[0].Set<Matricula>().ToList();
        }
    }
}
