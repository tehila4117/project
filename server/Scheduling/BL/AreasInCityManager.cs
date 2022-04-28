using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    class AreasInCityManager
    {
        static DBConection db = new DBConection();
        public static List<AreasInCityDTO> GetallAreasInCity()
        {
            List<AreasInCity> list = db.GetDbSet<AreasInCity>().ToList();
            List<AreasInCityDTO> dtoList = AreasInCityDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
