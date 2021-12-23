using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{        
    public class ConstraintsController : ApiController
        
    {
        ClassificationEntities1 db = new ClassificationEntities1();
        // GET: api/Priorities
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Priorities/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Priorities
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Priorities/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Priorities/5
        public void Delete(int id)
        {
        }
    }
}
