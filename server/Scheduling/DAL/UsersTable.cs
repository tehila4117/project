//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsersTable()
        {
            this.ConstraintsForPlacementTable = new HashSet<ConstraintsForPlacementTable>();
            this.ConstraintsForPlacementTable1 = new HashSet<ConstraintsForPlacementTable>();
        }
    
        public long UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Miles { get; set; }
        public string UserType { get; set; }
        public Nullable<long> InstitutionCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConstraintsForPlacementTable> ConstraintsForPlacementTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConstraintsForPlacementTable> ConstraintsForPlacementTable1 { get; set; }
        public virtual UserTypesTable UserTypesTable { get; set; }
    }
}
