using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    class StudentsManager
    {

        static DBConection db = new DBConection();
        public static List<StudentsDTO> GetallStudents()
        {
            List<Students> list = db.GetDbSet<Students>().ToList();
            List<StudentsDTO> dtoList = StudentsDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
