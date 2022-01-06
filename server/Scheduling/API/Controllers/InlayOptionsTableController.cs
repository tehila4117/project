using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace API.Controllers
{
    public class InlayOptionsTableController : ApiController
    {

        public List<DTOInlayOptionsTable> GetallInlayOptions()
        {
            List<DTOInlayOptionsTable> list = BL.ManagerInlayOptionsTable.GetallInlayOptions();
            return list;
        }

        // POST: api/DTOInlayOptionsTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOInlayOptionsTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOInlayOptionsTable/5
        public void Delete(int id)
        {
        }
    }
}
