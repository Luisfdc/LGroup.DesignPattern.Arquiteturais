using LGroup.Arquiteturais.Domain.Contracts.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
//Este namespace contem um service locator global e classe de melhores praticas da microsoft
using Microsoft.Practices.ServiceLocation;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Data.UnityOfWorlk
{
    public class UnityOfWrok : IUnityOfWork
    {
        private IEnumerable<DbContext> _contexts;
        private IEnumerable<DbContextTransaction> _transaction;
        public UnityOfWrok()
        {
            _transaction = new List<DbContextTransaction>();
            //Install-Package CommonServiceLocator
            //Agora estamos pegando todas as instacias de DbContext
            //Que agora são Contexto Interno e Externo
            _contexts = ServiceLocator.Current.GetAllInstances<DbContext>();
        }

        public IUnityOfWork BeginTransaction()
        {
            //Estou pegando os contexto de cadas banco de dados e estou abrindo a conexao e inserindo na lisata de transação
            _contexts.ToList().ForEach(x => _transaction.ToList().Add(x.Database.BeginTransaction()));
            return this;
        }

        public void Commit()
        {
            _transaction.ToList().ForEach(x => x.Commit());
        }

        public void Dispose()
        {
            _transaction.ToList().ForEach(x => x.Dispose());
        }

        public void Rollback()
        {
            _transaction.ToList().ForEach(x => x.Rollback());
        }
    }
}
