using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Model;
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

        public static Object SignUp(DTOUsersTable user)
        {
            UsersTable u = user.FromDtoToTable();
            db.Execute<UsersTable>(u, DBConection.ExecuteActions.Insert);
            return u;
        }
        public static Object  SignIn(UserDetails ud)
        {

            UsersTable u = db.GetDbSet<UsersTable>().FirstOrDefault(u1 => u1.UserName == ud.UserName);
            if (u == null)
                return new { success = false,  massage = "user does not exist" };
            else if (!u.Password.Equals(ud.Password)) 
                return new { success = false,  massage = "Password is wrong" };
            else
                return new{ success = true ,user = new DTOUsersTable(u),massage = "Login success"};
        }

  }
}
