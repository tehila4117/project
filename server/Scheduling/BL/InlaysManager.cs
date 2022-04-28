using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    class InlaysManager
    {
        static DBConection db = new DBConection();
        public static List<InlaysDTO> GetallAreasInCity()
        {
            List<Inlays> list = db.GetDbSet<Inlays>().ToList();
            List<InlaysDTO> dtoList = InlaysDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
