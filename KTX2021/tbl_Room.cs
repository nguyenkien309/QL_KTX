//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dormitory_Management_2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Room()
        {
            this.tbl_Bill = new HashSet<tbl_Bill>();
            this.tbl_Contract = new HashSet<tbl_Contract>();
        }
    
        public string Building_Room { get; set; }
        public string Name_Room { get; set; }
        public string Type_Room { get; set; }
        public Nullable<int> Maximum_Number_of_People_Room { get; set; }
        public Nullable<int> Current_Number_of_People_Room { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Bill> tbl_Bill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Contract> tbl_Contract { get; set; }
    }
}
