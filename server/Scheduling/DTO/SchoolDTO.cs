using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SchoolDTO
    {
        public long InstitutionCode { get; set; }
        public string userName { get; set; }
        public Nullable<int> Password { get; set; }
        public Nullable<int> NumberOfChildrenInClass { get; set; }

        public SchoolDTO()
        {

        }

        public SchoolDTO(School s)
        {
            this.InstitutionCode = s.InstitutionCode;
            this.userName = s.userName;
            this.Password = s.Password;
            this.NumberOfChildrenInClass = s.NumberOfChildrenInClass;
        }

        public School FromDtoToTable()
        {
            School school= new School();
            school.InstitutionCode = InstitutionCode;
            school.userName = userName;
            school.Password = Password;
            school.NumberOfChildrenInClass = NumberOfChildrenInClass;

            return school;

        }


        public static List<SchoolDTO> CreatDtoList(List<School> LIST)
        {
            List<SchoolDTO> dtolist = new List<SchoolDTO>();
            foreach (var a in LIST)
            {
                SchoolDTO dtoSchool = new SchoolDTO(a);
                dtolist.Add(dtoSchool);
            }
            return dtolist;

        }
    }
}
