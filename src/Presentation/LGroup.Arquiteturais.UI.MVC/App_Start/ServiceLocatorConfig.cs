using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Vamos chamar esse cara para inicializar os containers
using LGroup.Arquiteturais.Ioc.ServiceLocator;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;

namespace LGroup.Arquiteturais.UI.MVC.App_Start
{
    public class ServiceLocatorConfig
    {
        //Para que o MVC se adapte aos containers do SimpliInjetor
        //e Para que possamos instalar o seguinte item:
        //Install-Package simpleinjector.integration.web.mvc

        public static void Initialize()
        {
            var container = new Container();

            container.Options.DefaultLifestyle = new WebRequestLifestyle();

            //Registrando as Controllers do MVC
            container.RegisterMvcControllers();

            //Nota: Quem define o LifeStyle é o UI
            container.Initialize(new WebRequestLifestyle());

            //Não obrigatório
            //Vai em cada contrutor e verifica se tem uma interface resgistrada
            //Se tiver ele verifica se tem no container, se tiver OK
            //Se Não um erro ocorrera
            container.Verify();

            //Aqui está resolvendo os contrutores das Controllers
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}