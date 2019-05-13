﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ITestService _testService;
        public ValuesController(ITestService testService)
        {
            _testService = testService;

        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", _testService.Get() };
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