using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    class AreasInCityDTO
    {
        public long AreaCityCode { get; set; }
        public string NameAreaCity { get; set; }
        public Nullable<long> CityCode { get; set; }

        public AreasInCityDTO()
        {

        }



        public AreasInCityDTO(AreasInCity a)
        {
            this.AreaCityCode = a.AreaCityCode;
            this.NameAreaCity = a.NameAreaCity;
            this.CityCode = a.CityCode;
        }

        public AreasInCity FromDtoToTable()
        {
            AreasInCity areas = new AreasInCity();
            areas.AreaCityCode = AreaCityCode;
            areas.NameAreaCity = NameAreaCity;
            areas.CityCode = CityCode;
            

            return areas;

        }


        public static List<AreasInCityDTO> CreatDtoList(List<AreasInCity> LIST)
        {
            List<AreasInCityDTO> dtolist = new List<AreasInCityDTO>();
            foreach (var a in LIST)
            {
                AreasInCityDTO dtoAreasInCity = new AreasInCityDTO(a);
                dtolist.Add(dtoAreasInCity);
            }
            return dtolist;

        }
    }
}
