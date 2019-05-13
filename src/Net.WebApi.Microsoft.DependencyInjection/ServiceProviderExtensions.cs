using System;
using System.Linq;
using System.Reflection;
using System.Web.Http.Controllers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection RegisterApiControllers(this IServiceCollection services, params Assembly[] controllerAssemblies)
        {
            return RegisterApiControllers(services, "Controller", controllerAssemblies);
        }

        public static IServiceCollection RegisterApiControllers(this IServiceCollection services, string controllerSuffix, params Assembly[] controllerAssemblies)
        {
            foreach (var controllerAssemblie in controllerAssemblies)
            {
                var controllerTypes = controllerAssemblie.GetExportedTypes().Where(t => typeof(IHttpController).IsAssignableFrom(t) && t.Name.EndsWith(controllerSuffix, StringComparison.Ordinal));
                foreach (var type in controllerTypes)
                {
                    services.AddTransient(type);
                }
            }
            return services;
        }
    }
}
