using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Accord.Genetic;
using DAL;
using DTO;

namespace BL
{
    class Genetic
    {
        DBConection DBConection = new DBConection();
        List<Students> students = new List<Students>();


        public Genetic()
        {

            students = StudentsManager.GetAllStudents().Where(a => a.UserType == 3).ToList();

        }
        public int CalculateNumOfClass(long schoolcode)
        {
            return students.Count / SchoolManager.GetallSchool().Where(a => a.InstitutionCode == schoolcode).FirstOrDefault().NumberOfChildrenInClass;

        }

        public int CalculateNumFoStudentPerClass(long schoolcode)
        {
            int numclass = CalculateNumFoStudentPerClass(schoolcode);
            return students.Count / numclass;
        }
    }
    public static List<StudentsManager> GetAllStudentInInstitution(long schoolcode)//מחזיר רשימת תלמידים של מוסד מסוים  

    {
        return StudentsManager.GetallStudents().Where(s => s.InstitutionCode == schoolcode).ToList();
    }


    Random r = new Random();

    int[] clasess = new int[CalculateNumOfClass()];//מספר הכיתות
 
        for (int i = 0; i<GetAllStudentInInstitution.Count; i++)
			{
          
			}
        
        
}


