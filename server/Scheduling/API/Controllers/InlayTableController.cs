using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class InlayTableController : ApiController
    {
         public List<DTOInlayTable> GetallInlay()
        {
            List<DTOInlayTable> list = BL.ManagerInlayTable.GetallInlay();
            return list;
        }
       
        // POST: api/DTOInlayTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOInlayTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOInlayTable/5
        public void Delete(int id)
        {
        }
    }
}
