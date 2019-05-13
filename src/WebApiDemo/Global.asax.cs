using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebApiDemo.Services;

namespace WebApiDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var config = GlobalConfiguration.Configuration;

            var services = new ServiceCollection();
            //ע��Web Api������
            services.RegisterApiControllers(Assembly.GetExecutingAssembly());

            services.AddScoped<ITestService, TestService>();

            //�滻DependencyResolver
            config.DependencyResolver = new MicrosoftDependencyResolver(services.BuildServiceProvider());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
