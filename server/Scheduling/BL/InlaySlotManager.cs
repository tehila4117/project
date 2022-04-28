using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    class InlaySlotManager
    {
        static DBConection db = new DBConection();
        public static List<InlaySlotDTO> GetallAreasInCity()
        {
            List<InlaySlot> list = db.GetDbSet<InlaySlot>().ToList();
            List<InlaySlotDTO> dtoList = InlaySlotDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
