# Net.WebApi.Microsoft.DependencyInjection
Net Framework 4.7.2 以上版本的Web Api , 使用Microsoft.Extensions.DependencyInjection

#### 使用方法

> Global.asax相关配置

```c#

protected void Application_Start()
{
    var config = GlobalConfiguration.Configuration;

    var services = new ServiceCollection();
    //注册Web Api控制器
    services.RegisterApiControllers(Assembly.GetExecutingAssembly());

    services.AddScoped<ITestService, TestService>();

    //替换DependencyResolver
    config.DependencyResolver = new MicrosoftDependencyResolver(services.BuildServiceProvider());

    GlobalConfiguration.Configure(WebApiConfig.Register);
}

```
