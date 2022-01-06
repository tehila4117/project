using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class ManagerUserTypesTable
    {

        static DBConection db = new DBConection();

        public static List<DTOUserTypesTable> GetallUserTypes()
        {
            List<UserTypesTable> list = db.GetDbSet<UserTypesTable>().ToList();
            List<DTOUserTypesTable> dtoList = DTOUserTypesTable.CreatDtoList(list);
            return dtoList;
        }
    }
}
