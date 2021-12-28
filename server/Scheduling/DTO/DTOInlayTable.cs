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
    }
}
