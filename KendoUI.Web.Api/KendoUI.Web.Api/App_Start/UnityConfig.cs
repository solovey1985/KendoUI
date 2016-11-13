using System;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace KendoUI.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterTypes(AllClasses.FromAssemblies(), 
                                    WithMappings.FromMatchingInterface, 
                                    WithName.TypeName, 
                                    WithLifetime.ContainerControlled
                                   ); 
           GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}