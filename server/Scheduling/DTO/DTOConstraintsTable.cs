using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOConstraintsTable
    {
        public long ConstraintCode { get; set; }
        public string NameConstraint { get; set; }
        public long UserType { get; set; }
        public long InstitutionCode { get; set; }
        
        public DTOConstraintsTable()
        {

        }

        public DTOConstraintsTable(ConstraintsTable C)
        {
            this.ConstraintCode = C.ConstraintCode;
            this.NameConstraint = C.NameConstraint;
            this.UserType =(long)C.UserType;
            this.InstitutionCode = (long)C.InstitutionCode;
        }

        public static List<DTOConstraintsTable> CreatDtoList(List<ConstraintsTable> LIST)
        {
            List<DTOConstraintsTable> dtolist = new List<DTOConstraintsTable>();
            foreach (var c in LIST)
            {
                DTOConstraintsTable dtoconstraintsforplacementtable = new DTOConstraintsTable(c);
                dtolist.Add(dtoconstraintsforplacementtable);
            }
            return dtolist;

        }
    }
}
