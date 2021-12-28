using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOInlayOptionsTable
    {
        public long ForcedOptionCode { get; set; }
        public string option { get; set; }
        public long OptionCode { get; set; }

        public DTOInlayOptionsTable()
        {

        }
        public DTOInlayOptionsTable(InlayOptionsTable i)
        {
            this.ForcedOptionCode = i.ForcedOptionCode;
            this.option = i.option;
            this.OptionCode = (long)i.OptionCode;
        } 
        
    }
}
