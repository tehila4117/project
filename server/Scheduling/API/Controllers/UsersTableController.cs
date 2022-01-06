using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UsersTableController : ApiController
    {//api/UsersTable/GetallUsers
           public List<DTOUsersTable> GetallUsers()
           {
            List<DTOUsersTable> list = BL.ManagerUsersTable.GetallUsers();
            return list;
           }

        // POST: api/DTOUsersTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DTOUsersTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DTOUsersTable/5
        public void Delete(int id)
        {
        }
    }
}
