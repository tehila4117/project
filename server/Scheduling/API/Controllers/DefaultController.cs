using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace API.Controllers
{
    public class DefaultController : ApiController
    {

         
        public List<DTOConstraintsTable> GetallConstraints()
        {
            List < DTOConstraintsTable > list =  BL.Default.GetallConstraints();
            return list;
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
