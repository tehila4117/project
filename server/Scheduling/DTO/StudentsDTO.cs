using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    class StudentsDTO
    {

        public long StudentCode { get; set; }
        public string StudentName { get; set; }
        public Nullable<long> AreaCityCode { get; set; }
        public Nullable<double> GradePointAverage { get; set; }
        public Nullable<int> SocialInvolvement { get; set; }
        public Nullable<long> PreviousSchoolCode { get; set; }
        public Nullable<long> InstitutionCode { get; set; }

        public StudentsDTO()
        {

        }

        public StudentsDTO(Students s)
        {
            this.StudentCode = s.StudentCode;
            this.StudentName = s.StudentName;
            this.AreaCityCode = s.AreaCityCode;
            this.GradePointAverage = s.GradePointAverage;
            this.SocialInvolvement = s.SocialInvolvement;
            this.PreviousSchoolCode = s.PreviousSchoolCode;
            this.InstitutionCode = s.InstitutionCode;
        }
        public Students FromDtoToTable()
        {
            Students Student = new Students();
            Student.StudentCode = StudentCode;
            Student.StudentName = StudentName;
            Student.AreaCityCode = AreaCityCode;
            Student.GradePointAverage = GradePointAverage;
            Student.SocialInvolvement = SocialInvolvement;
            Student.PreviousSchoolCode = PreviousSchoolCode;
            Student.InstitutionCode = InstitutionCode;

            return Student;

        }


        public static List<StudentsDTO> CreatDtoList(List<Students> LIST)
        {
            List<StudentsDTO> dtolist = new List<StudentsDTO>();
            foreach (var a in LIST)
            {
                StudentsDTO dtoStudents = new StudentsDTO(a);
                dtolist.Add(dtoStudents);
            }
            return dtolist;

        }
    }
}
