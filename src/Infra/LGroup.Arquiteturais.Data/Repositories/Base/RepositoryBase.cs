using LGroup.Arquiteturais.Domain.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Data.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T>
    {
        public void Add(T aluno)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
