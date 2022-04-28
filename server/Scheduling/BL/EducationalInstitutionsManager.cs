using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    class EducationalInstitutionsManager
    {
        static DBConection db = new DBConection();

        public static List<EducationalInstitutionsDTO> GetallCities()
        {
            List<EducationalInstitutions> list = db.GetDbSet<EducationalInstitutions>().ToList();
            List<EducationalInstitutionsDTO> dtoList = EducationalInstitutionsDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
