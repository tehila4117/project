using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class ManagerInlayOptionsTable
    {
        static DBConection db = new DBConection();

        /// <summary>
        /// מביאה את כל רשימת האילוצים
        /// </summary>
        /// <returns>
        /// מחזירה רשימת DTO של האילוצים
        /// </returns>
        public static  List<DTOInlayOptionsTable> GetallInlayOptions()
        {
            List<InlayOptionsTable> list = db.GetDbSet<InlayOptionsTable>().ToList();
            List<DTOInlayOptionsTable> dtoList = DTOInlayOptionsTable.CreatDtoList(list);
            return dtoList;
        }
      /// <summary>
      /// מקבלת קוד אילוץ ומחזירה רשימה של פרטי האילוץ לפי הקוד
      /// </summary>
      /// <param name="constraintCode">קוד אילוץ</param>
      /// <returns>מחזירה רשימה של DTO של פרטי האילוץ</returns>
        public List<DTOInlayOptionsTable> GetOptionsByConstraint(long constraintCode)
        {
          return ManagerInlayOptionsTable.GetallInlayOptions().Where(a => a.OptionCode == constraintCode).ToList();
        }
    }
}
