using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    class InlaySlotDTO
    {
        public long SlotCode { get; set; }
        public Nullable<long> InlayCode { get; set; }
        public Nullable<long> StudentCode { get; set; }
        public Nullable<int> NumOfClass { get; set; }

        public InlaySlotDTO()
        {

        }

        public InlaySlotDTO(InlaySlot s)
        {
            this.SlotCode = s.SlotCode;
            this.InlayCode = s.InlayCode;
            this.StudentCode = s.StudentCode;
            this.NumOfClass = s.NumOfClass;
        }

        public InlaySlot FromDtoToTable()
        {
            InlaySlot InlaySlot = new InlaySlot();
            InlaySlot.SlotCode = SlotCode;
            InlaySlot.InlayCode = InlayCode;
            InlaySlot.NumOfClass = NumOfClass;


            return InlaySlot;

        }


        public static List<InlaySlotDTO> CreatDtoList(List<InlaySlot> LIST)
        {
            List<InlaySlotDTO> dtolist = new List<InlaySlotDTO>();
            foreach (var a in LIST)
            {
                InlaySlotDTO dtoInlaySlot = new InlaySlotDTO(a);
                dtolist.Add(dtoInlaySlot);
            }
            return dtolist;

        }
    }
}
