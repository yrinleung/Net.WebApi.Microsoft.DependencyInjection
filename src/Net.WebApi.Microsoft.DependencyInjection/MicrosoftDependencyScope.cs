using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace Net.WebApi.Microsoft.DependencyInjection
{
    internal class MicrosoftDependencyScope : IDependencyScope
    {
        private IServiceScope _serviceScope;
        public MicrosoftDependencyScope(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.CreateScope();
        }

        public void Dispose()
        {
            _serviceScope.Dispose();
        }

        public object GetService(Type serviceType)
        {
            return _serviceScope.ServiceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceScope.ServiceProvider.GetServices(serviceType);
        }
    }
}
