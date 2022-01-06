using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOInstitutionsTables
    {
        public long InstitutionCode { get; set; }
        public string InstitutionName { get; set; }

        public DTOInstitutionsTables()
        {

        }

        public DTOInstitutionsTables(InstitutionsTables i)
        {
            this.InstitutionCode = i.InstitutionCode;
            this.InstitutionName = i.InstitutionName;
        }

        public InstitutionsTables FromDtoToTable(DTOInstitutionsTables i)
        {
            InstitutionsTables Institutions = new InstitutionsTables();
            Institutions.InstitutionCode = InstitutionCode;
            Institutions.InstitutionName = InstitutionName;
            return Institutions;
        }


        public static List<DTOInstitutionsTables> CreatDtoList(List<InstitutionsTables> LIST)
        {
            List<DTOInstitutionsTables> dtolist = new List<DTOInstitutionsTables>();
            foreach (var c in LIST)
            {
                DTOInstitutionsTables dtoInstitutionsTables = new DTOInstitutionsTables(c);
                dtolist.Add(dtoInstitutionsTables);
            }
            return dtolist;

        }
    }
}
