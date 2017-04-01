using LGroup.Arquiteturais.App.Contracts;
using LGroup.Arquiteturais.Domain.Contracts.Repositories;
using LGroup.Arquiteturais.Domain.Contracts.UnityOfWork;
using LGroup.Arquiteturais.Domain.DomainModels.Entities;
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
        private IAlunoRepository _alunoRepository;
        private IMatriculaRepository _matriculaRepository;

        //Essa classe é responsavel por orquestrar os serviçoes e tarefas externas
        //Logo é nele que tenho que ter a transação

        private IUnityOfWork _unityOfWork;
        public MatriculaApplicationService(IUnityOfWork unityOfWork,IAlunoRepository alunoRepository, IMatriculaRepository matriculaRepository)
        {
            _unityOfWork = unityOfWork;
            _alunoRepository = alunoRepository;
            _matriculaRepository = matriculaRepository;
        }

        public void Add(Matricula matricula)
        {
            using (var connection = _unityOfWork.BeginTransaction())
            {
                try

                {
                    if (matricula.Aluno == null)
                        throw new ApplicationException("Aluno não informado");

                    _matriculaRepository.Add(matricula);


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
