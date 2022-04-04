using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    class ManagerConstraintsTable
    {
       

            static DBConection db = new DBConection();
        /// <summary>
        /// מחזירה את כל האילוצים
        /// </summary>
        /// <returns>
        /// רשימה DTO של כל האילוצים</returns>
            public static List<DTOConstraintsTable> GetallConstraints()
            {
                List<ConstraintsTable> list = db.GetDbSet<ConstraintsTable>().ToList();
                List<DTOConstraintsTable> dtoList = DTOConstraintsTable.CreatDtoList(list);
                return dtoList;
            }

         /// <summary>
         /// כל האילוצים השייכים למוסד מסויים
         /// </summary>
         /// <param name="institutionCode"> קוד המוסד</param>
         /// <returns>
         /// מחזירה רשימה של האילוצים בהתאם למוסד
         /// </returns>
            public List<DTOConstraintsTable> GetConstraintByUserCode(string userCode)
            {
                return ManagerConstraintsTable.GetallConstraints().Where(a => a.UserCode == userCode).ToList();
            }
         

        
    }
}
