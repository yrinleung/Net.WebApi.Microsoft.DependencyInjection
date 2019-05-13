using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Services
{
    public interface ITestService
    {
        string Get();
    }
    public class TestService : ITestService
    {
        public string Get()
        {
            return "原生DI输出的";
        }
    }
}