using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.Contracts.UnityOfWork
{
    public interface IUnityOfWork:IDisposable
    {
        //Duas formas de fazer
        //1 - Transacionando apenas o objeto
        //2 - Ou transacionando o objeto e o banco
        IUnityOfWork BeginTransaction();
        void Commit();
        void Rollback(); 
    }
}
