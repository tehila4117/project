using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class Default
    {

        static DBConection db = new DBConection();

        public static List<DTOConstraintsTable> GetallConstraints()
        {
            List<ConstraintsTable> list = db.GetDbSet<ConstraintsTable>().ToList();
            List<DTOConstraintsTable> dtoList = DTOConstraintsTable.CreatDtoList(list);
            return dtoList;
        }

    }
}
