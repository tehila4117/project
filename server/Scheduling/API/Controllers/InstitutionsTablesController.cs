using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class InstitutionsTablesController : ApiController
    {
         public List<DTOInstitutionsTables> GetallInstitutions()
        {
            List<DTOInstitutionsTables> list = BL.ManagerInstitutionsTables.GetallInstitutions();
            return list;
        }
      
        // POST: api/DTOInstitutionsTables
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOInstitutionsTables/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOInstitutionsTables/5
        public void Delete(int id)
        {
        }
    }
}
