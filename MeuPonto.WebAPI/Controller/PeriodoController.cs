using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MeuPonto.WebAPI.Controller
{
    public class PeriodoController : ApiController
    {
        // GET: api/Periodo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Periodo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Periodo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Periodo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Periodo/5
        public void Delete(int id)
        {
        }
    }
}
