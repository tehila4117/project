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
        public long UserType { get; set; }
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
            this.UserType = (long)u.UserType;
            this.InstitutionCode = (long)u.InstitutionCode;

        }
    }
}
