using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOInlayTable
    {
        public long InlayCode { get; set; }
        public string InlayName { get; set; }
        public System.DateTime PlacementDate { get; set; }

        public DTOInlayTable()
        {

        }

        public DTOInlayTable(InlayTable i)
        {
            this.InlayCode = i.InlayCode;
            this.InlayName = i.InlayName;
            this.PlacementDate = i.PlacementDate;
        }

        public InlayTable FromDtoToTable(DTOInlayTable i)
        {
            InlayTable Inlay = new InlayTable();
            Inlay.InlayCode = InlayCode;
            Inlay.InlayName = InlayName;
            Inlay.PlacementDate = PlacementDate;
            return Inlay;
        }


        public static List<DTOInlayTable> CreatDtoList(List<InlayTable> LIST)
        {
            List<DTOInlayTable> dtolist = new List<DTOInlayTable>();
            foreach (var c in LIST)
            {
                DTOInlayTable dtoInlayTable = new DTOInlayTable(c);
                dtolist.Add(dtoInlayTable);
            }
            return dtolist;

        }
    }
}
