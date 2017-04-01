using LGroup.Arquiteturais.App.Contracts;
using LGroup.Arquiteturais.Domain.Contracts.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.App.Services
{
    public class MatriculaApplicationService
        : IMatriculaApplicationService
    {
        //Essa classe é responsavel por orquestrar os serviçoes e tarefas externas
        //Logo é nele que tenho que ter a transação

        private IUnityOfWork _unityOfWork;
        public MatriculaApplicationService(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public void Add()
        {
            using (var connection = _unityOfWork.BeginTransaction())
            {
                try
                {
                    connection.Commit();
                }
                catch
                {
                    connection.Rollback();
                }
                finally
                {

                }

            }
        }
    }
}
