using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    class InlaysDTO
    {
        public long InlayCode { get; set; }
        public string InlayName { get; set; }
        public Nullable<System.DateTime> InlayDate { get; set; }
        public Nullable<long> InstitutionCode { get; set; }

        public InlaysDTO()
        {

        }

        public InlaysDTO(Inlays i)
        {
            this.InlayCode = i.InlayCode;
            this.InlayName = i.InlayName;
            this.InlayDate = i.InlayDate;
            this.InstitutionCode =i.InstitutionCode;
        }
        public Inlays FromDtoToTable()
        {
            Inlays inlay = new Inlays();
            inlay.InlayCode = InlayCode;
            inlay.InlayName = InlayName;
            inlay.InlayDate = InlayDate;


            return inlay;

        }


        public static List<InlaysDTO> CreatDtoList(List<Inlays> LIST)
        {
            List<InlaysDTO> dtolist = new List<InlaysDTO>();
            foreach (var i in LIST)
            {
                InlaysDTO dtoInlays = new InlaysDTO(i);
                dtolist.Add(dtoInlays);
            }
            return dtolist;

        }
    }
}
