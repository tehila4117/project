using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUserTypesTable
    {
        public string UserTypeCode { get; set; }
        public string UsernameType { get; set; }

        public DTOUserTypesTable()
        {

        }

        public DTOUserTypesTable(UserTypesTable u)
        {
            this.UserTypeCode = u.UserTypeCode;
            this.UsernameType = u.UsernameType;
        }

        public UserTypesTable FromDtoToTable(DTOUserTypesTable u)
        {
            UserTypesTable UserType = new UserTypesTable();
            UserType.UserTypeCode = u.UserTypeCode;
            UserType.UsernameType = u.UsernameType;
            return UserType;
        }




        public static List<DTOUserTypesTable> CreatDtoList(List<UserTypesTable> LIST)
        {
            List<DTOUserTypesTable> dtolist = new List<DTOUserTypesTable>();
            foreach (var c in LIST)
            {
                DTOUserTypesTable dtoUserTypesTable = new DTOUserTypesTable(c);
                dtolist.Add(dtoUserTypesTable);
            }
            return dtolist;

        }
    }
}
