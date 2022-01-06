using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class ManagerInstitutionsTables
    {
        static DBConection db = new DBConection();
        public static List<DTOInstitutionsTables> GetallInstitutions()
        {
            List<InstitutionsTables> list = db.GetDbSet<InstitutionsTables>().ToList();
            List<DTOInstitutionsTables> dtoList = DTOInstitutionsTables.CreatDtoList(list);
            return dtoList;
        }
    }
}
