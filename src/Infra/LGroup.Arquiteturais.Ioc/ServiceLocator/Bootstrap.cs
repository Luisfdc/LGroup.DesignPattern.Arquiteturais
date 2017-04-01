using LGroup.Arquiteturais.App.Contracts;
using LGroup.Arquiteturais.App.Services;
using LGroup.Arquiteturais.Data.Contexts;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using CommonServiceLocator.SimpleInjectorAdapter;
using serviceLocator = Microsoft.Practices.ServiceLocation;

namespace LGroup.Arquiteturais.Ioc.ServiceLocator
{
    public static class Bootstrap
    {
        //Pacotes de instralação
        //Install-Package Entity FrameWork
        //Install-Package SimpleInjector
        //Install-Package CommonServiceLocator.SimpleInjectorAdapter -Version 1.3.0.11343
        public static void Initialize(this Container container, Lifestyle lifestyle)
        {
            var types = new List<Type>
            {
                typeof(ContextInterno),
                typeof(ContextExterno)
            };

            container.RegisterCollection<DbContext>(types);
            types.ForEach(x => container.Register(x, x, lifestyle));

            //Toda vez que eu instanciar a interface:IMatriculaApplicationService
            //Em um contrutor, a interface IMatriculaApplicationService var retornar
            //a classe MatriculaApplicationService já instanciada
            //Nota: não é preciso dar "new"
            container.Register<IMatriculaApplicationService, MatriculaApplicationService > (lifestyle);


            //Estamos pegando o cantainer do service locator e estamos adicionando o container do simpleInjector
            //Agora o container do service locator ja está preenchido
            serviceLocator.ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}
