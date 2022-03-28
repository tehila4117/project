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
        public string UserCode { get; set; }
       
        
        public DTOConstraintsTable()
        {

        }

        public DTOConstraintsTable(ConstraintsTable C)
        {
            this.ConstraintCode = C.ConstraintCode;
            this.NameConstraint = C.NameConstraint;
            this.UserCode = C.UserCode;
           
        }

        public ConstraintsTable FromDtoToTable(DTOConstraintsTable C)
        {
            ConstraintsTable Constraint = new ConstraintsTable();
            Constraint.ConstraintCode =ConstraintCode;
            Constraint.NameConstraint =NameConstraint;
            Constraint.UserCode = UserCode;
 
            return Constraint;
        }


        public static List<DTOConstraintsTable> CreatDtoList(List<ConstraintsTable> LIST)
        {
            List<DTOConstraintsTable> dtolist = new List<DTOConstraintsTable>();
            foreach (var c in LIST)
            {
                DTOConstraintsTable dtoInlayOptionsTable = new DTOConstraintsTable(c);
                dtolist.Add(dtoInlayOptionsTable);
            }
            return dtolist;

        }
    }
}
