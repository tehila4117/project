using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUsersTable
    {
        public long UserCode { get; set; }
        public string UserName { get; set; }
        public long Password { get; set; }
        public string Miles { get; set; }
        public string UserType { get; set; }
        public long InstitutionCode { get; set; }


        public DTOUsersTable()
        {

        }

        public DTOUsersTable(UsersTable u)
        {
            this.UserCode = u.UserCode;
            this.UserName = u.UserName;
            this.Password = (long)u.Password;
            this.Miles = u.Miles;
            this.UserType = u.UserType;
            this.InstitutionCode = (long)u.InstitutionCode;

        }

        public UsersTable FromDtoToTable()
        {
            UsersTable Users = new UsersTable();
            Users.UserCode =UserCode;
            Users.UserName =UserName;
            Users.Password = Password;
            Users.Miles =Miles;
            Users.UserType =UserType;
            Users.InstitutionCode = InstitutionCode;
            return Users;

        }


        public static List<DTOUsersTable> CreatDtoList(List<UsersTable> LIST)
        {
            List<DTOUsersTable> dtolist = new List<DTOUsersTable>();
            foreach (var c in LIST)
            {
                DTOUsersTable dtoUsersTable = new DTOUsersTable(c);
                dtolist.Add(dtoUsersTable);
            }
            return dtolist;

        }
    }
}
