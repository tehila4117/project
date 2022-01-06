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

        public InlayOptionsTable FromDtoToTable(DTOInlayOptionsTable i)
        {
            InlayOptionsTable InlayOptions = new InlayOptionsTable();
            InlayOptions.ForcedOptionCode = i.ForcedOptionCode;
            InlayOptions.option = i.option;
            InlayOptions.OptionCode = (long)i.OptionCode;
           
            return InlayOptions;
        }



        public static List<DTOInlayOptionsTable> CreatDtoList(List<InlayOptionsTable> LIST)
        {
            List<DTOInlayOptionsTable> dtolist = new List<DTOInlayOptionsTable>();
            foreach (var c in LIST)
            {
                DTOInlayOptionsTable dtoInlayOptionsTable = new DTOInlayOptionsTable(c);
                dtolist.Add(dtoInlayOptionsTable);
            }
            return dtolist;

        }
    }
}
