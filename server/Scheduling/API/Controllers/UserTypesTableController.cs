using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserTypesTableController : ApiController
    {
        public List<DTOUserTypesTable> GetallUserTypes()
           {
            List<DTOUserTypesTable> list = BL.ManagerUserTypesTable.GetallUserTypes();
            return list;
           }

        // POST: api/DTOUserTypesTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOUserTypesTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOUserTypesTable/5
        public void Delete(int id)
        {
        }
    }
}
