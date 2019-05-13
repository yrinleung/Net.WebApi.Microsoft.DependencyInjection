using Net.WebApi.Microsoft.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace Microsoft.Extensions.DependencyInjection
{
    public class MicrosoftDependencyResolver : IDependencyResolver
    {
        protected IServiceProvider serviceProvider;
        public MicrosoftDependencyResolver(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IDependencyScope BeginScope()
        {
            return new MicrosoftDependencyScope(serviceProvider);
        }

        public void Dispose()
        {

        }

        public object GetService(Type serviceType)
        {
            return this.serviceProvider.GetService(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.serviceProvider.GetServices(serviceType);
        }
    }
}
