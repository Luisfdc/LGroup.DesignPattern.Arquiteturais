using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.Contracts.Repositories.Base
{
    public interface IRepositoryBase<T>
    {
        void Add(T aluno);
        IEnumerable<T> GetAll();
    }
}
