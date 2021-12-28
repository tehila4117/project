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
    }
}
