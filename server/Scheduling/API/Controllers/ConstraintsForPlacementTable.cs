using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
namespace API.Controllers
{
    public class ConstraintsForPlacementTable : ApiController
    {
        public List<DTOConstraintsForPlacementTable> GetallConstraintsForPlacement()
           {
            List<DTOConstraintsForPlacementTable> list = BL.ManagerConstraintsForPlacementTable.GetallConstraintsForPlacement();
            return list;
           }

        // POST: api/DTOConstraintsTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOConstraintsTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOConstraintsTable/5
        public void Delete(int id)
        {
        }
    }
}
