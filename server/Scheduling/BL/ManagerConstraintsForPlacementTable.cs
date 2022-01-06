using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public static class ManagerConstraintsForPlacementTable
    {

            static DBConection db = new DBConection();

            public static List<DTOConstraintsForPlacementTable> GetallConstraintsForPlacement()
            {
                List<ConstraintsForPlacementTable> list = db.GetDbSet<ConstraintsForPlacementTable>().ToList();
                List<DTOConstraintsForPlacementTable> dtoList = DTOConstraintsForPlacementTable.CreatDtoList(list);
                return dtoList;
            }

        
    }
}
