using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ITestService _testService;
        private readonly IHttpClientFactory _clientFactory;
        public ValuesController(ITestService testService, IHttpClientFactory clientFactory)
        {
            _testService = testService;
            _clientFactory = clientFactory;

        }
        // GET api/values
        public async Task<IEnumerable<string>> Get()
        {
            var client = _clientFactory.CreateClient();
            var result = await client.GetStringAsync("https://www.baidu.com/");

            return new string[] { "value1", "value2", _testService.Get(), result };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}