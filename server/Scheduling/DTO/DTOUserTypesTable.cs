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
        public long UserTypeCode { get; set; }
        public string UsernameType { get; set; }

        public DTOUserTypesTable()
        {

        }

        public DTOUserTypesTable(UserTypesTable u)
        {
            this.UserTypeCode = u.UserTypeCode;
            this.UsernameType = u.UsernameType;
        }
    }
}
