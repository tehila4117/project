using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class ManagerUsersTable
    {

        static DBConection db = new DBConection();

        public static List<DTOUsersTable> GetallUsers()
        {
            List<UsersTable> list = db.GetDbSet<UsersTable>().ToList();
            List<DTOUsersTable> dtoList = DTOUsersTable.CreatDtoList(list);
            return dtoList;
        }

        public static UsersTable SingUp(DTOUsersTable user)
        {
            UsersTable u = user.FromDtoToTable();
            db.Execute<UsersTable>(u, DBConection.ExecuteActions.Insert);
            return u;
        }
  }
}
