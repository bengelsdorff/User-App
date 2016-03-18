using Autofac;
using Autofac.Integration.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace UserApp
{
    public class IoCConfig
    {
        public static void Initialize()
        {

            var builder = new ContainerBuilder();

            //register all controllers found in this assembly
            builder.RegisterControllers(Assembly.GetExecutingAssembly());


            //add Core classes to the container as single instance
            builder.RegisterAssemblyTypes(typeof(Domain.Context).Assembly).AsImplementedInterfaces().InstancePerRequest();

            //add ServiceProvider classes to the container as single instance
            builder.RegisterAssemblyTypes(typeof(Core.UserBusinessLogic).Assembly).AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();

            //set the MVC DependencyResolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            

        }
    }
}