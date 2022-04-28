using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    class EducationalInstitutionsDTO
    {
        public long EducationalInstitutionCode { get; set; }
        public string InstitutionName { get; set; }


        public EducationalInstitutionsDTO()
        {

        }

        public EducationalInstitutionsDTO(EducationalInstitutions e)
        {
            this.EducationalInstitutionCode = e.EducationalInstitutionCode;
            this.InstitutionName = e.InstitutionName;
        }


        public EducationalInstitutions FromDtoToTable()
        {
            EducationalInstitutions edInstitions = new EducationalInstitutions();
            edInstitions.EducationalInstitutionCode = EducationalInstitutionCode;
            edInstitions.InstitutionName = InstitutionName;
            


            return edInstitions;

        }


        public static List<EducationalInstitutionsDTO> CreatDtoList(List<EducationalInstitutions> LIST)
        {
            List<EducationalInstitutionsDTO> dtolist = new List<EducationalInstitutionsDTO>();
            foreach (var a in LIST)
            {
                EducationalInstitutionsDTO dtoAreasInCity = new EducationalInstitutionsDTO(a);
                dtolist.Add(dtoAreasInCity);
            }
            return dtolist;

        }
    }
}
