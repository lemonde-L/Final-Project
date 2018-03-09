//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }
    
        [DisplayName("Sale No.")]
        public int SaleKey { get; set; }
        [DisplayName("Date")]
        public Nullable<System.DateTime> SaleDate { get; set; }
        public Nullable<int> CustomerKey { get; set; }
        public Nullable<int> EmployeeKey { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
