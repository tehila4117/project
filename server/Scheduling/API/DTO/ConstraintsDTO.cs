using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class ConstraintsDTO
    {
        public long ConstraintCode { get; set; }
        public string NameConstraint { get; set; }
        public Nullable<long> UserType { get; set; }


        public ConstraintsDTO()
        {

        }
       
    }

}