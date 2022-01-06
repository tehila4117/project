using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOConstraintsForPlacementTable
    {
        public long InputCodeForPlacement { get; set; }
        public long InlayCode { get; set; }
        public long AuthorCodeForInlay { get; set; }
        public long ForcedOptionCode { get; set; }
        public long ForWhomTheInlay { get; set; }

        public DTOConstraintsForPlacementTable()
        {

        }
        public DTOConstraintsForPlacementTable(ConstraintsForPlacementTable c)
        {
            this.InputCodeForPlacement = c.InputCodeForPlacement;
            this.InlayCode = (long)c.InlayCode;
            this.AuthorCodeForInlay =(long) c.AuthorCodeForInlay;
            this.ForcedOptionCode = (long)c.ForcedOptionCode;
            this.ForWhomTheInlay = (long)c.ForWhomTheInlay;
        }

        public  ConstraintsForPlacementTable FromDtoToTable(DTOConstraintsForPlacementTable c)
        {
            ConstraintsForPlacementTable Constraint = new ConstraintsForPlacementTable();
            Constraint.InputCodeForPlacement =InputCodeForPlacement;
            Constraint.InlayCode =InlayCode;
            Constraint.AuthorCodeForInlay =AuthorCodeForInlay;
            Constraint.ForcedOptionCode =ForcedOptionCode;
            Constraint.ForWhomTheInlay =ForWhomTheInlay;
            return Constraint;
        }


        public static List<DTOConstraintsForPlacementTable> CreatDtoList(List<ConstraintsForPlacementTable> LIST)
        {
             List<DTOConstraintsForPlacementTable> dtolist = new List<DTOConstraintsForPlacementTable>();
             foreach(var c in LIST)
             {
               DTOConstraintsForPlacementTable DTOConstraintsForPlacementTable = new DTOConstraintsForPlacementTable(c);
               dtolist.Add(DTOConstraintsForPlacementTable);
             }
           return dtolist;

        }
}    
}
