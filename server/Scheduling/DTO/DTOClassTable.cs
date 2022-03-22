using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DTO
{
    class DTOClassId
    {
        public long ClassId { get; set; }
        public Nullable<long> InstitutionCode { get; set; }
        public Nullable<long> LayerClass { get; set; }

        public DTOClassId()
        {

        }
        public DTOClassId(ClassTable c)
        {
            this.ClassId = c.ClassId;
            this.InstitutionCode = c.InstitutionCode;
            this.LayerClass = c.LayerClass;
      

        }


        public ClassTable FromDtoToTable()
        {
            ClassTable Class = new ClassTable();
            Class.ClassId = ClassId;
            Class.InstitutionCode = InstitutionCode;
            Class.LayerClass = LayerClass;
          
            return Class;

        }


        public static List<DTOClassId> CreatDtoList(List<ClassTable> LIST)
        {
            List<DTOClassId> dtolist = new List<DTOClassId>();
            foreach (var c in LIST)
            {
                DTOClassId dtoUsersTable = new DTOClassId(c);
                dtolist.Add(dtoClassTable);
            }
            return dtolist;

        }
    }
}
