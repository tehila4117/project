using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    class CitiesManager
    {
        static DBConection db = new DBConection();

        public static List<CitiesDTO> GetallCities()
        {
            List<Cities> list = db.GetDbSet<Cities>().ToList();
            List<CitiesDTO> dtoList = CitiesDTO.CreatDtoList(list);
            return dtoList;
        }
    }
}
