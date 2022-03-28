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
        List<DTOUsersTable> students = new List<DTOUsersTable>();
        

        public Genetic()
        {
            
            students = ManagerUsersTable.GetAllStudents().ToList();
            Dictionary< >
        }
        public void generate()
        {
               
        }
    }
}
