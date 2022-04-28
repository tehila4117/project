using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    class CitiesDTO
    {
        public long CityCode { get; set; }
        public string CityName { get; set; }

        public CitiesDTO()
        {

        }

        public CitiesDTO(Cities c)
        {
            this.CityCode = c.CityCode;
            this.CityName = c.CityName;
        }
       

        public Cities FromDtoToTable()
        {
            Cities citie = new Cities();
            citie.CityCode = CityCode;
            citie.CityName = CityName;
            citie.CityCode = CityCode;


            return citie;

        }


        public static List<CitiesDTO> CreatDtoList(List<AreasInCity> LIST)
        {
            List<CitiesDTO> dtolist = new List<CitiesDTO>();
            foreach (var t in LIST)
            {
                CitiesDTO dtoCities = new CitiesDTO(t);
                dtolist.Add(dtoCities);
            }
            return dtolist;

        }
    }
}
