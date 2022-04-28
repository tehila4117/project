using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class SchoolManager
    {
        static DBConection db = new DBConection();
        public static List<SchoolDTO> GetallSchool()
        {
            List<School> list = db.GetDbSet<School>().ToList();
            List<SchoolDTO> dtoList = SchoolDTO.CreatDtoList(list);
            return dtoList;

        }
    }
}
