using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class ManagerInlayTable
    {
        static DBConection db = new DBConection();
        public static List<DTOInlayTable> GetallInlay()
        {
            List<InlayTable> list = db.GetDbSet<InlayTable>().ToList();
            List<DTOInlayTable> dtoList = DTOInlayTable.CreatDtoList(list);
            return dtoList;
        }

    }
}
