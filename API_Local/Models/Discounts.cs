//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Local.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discounts()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int id { get; set; }
        public string Code { get; set; }
        public Nullable<int> id_Type { get; set; }
        public Nullable<double> Value___ { get; set; }
        public Nullable<double> Value___1 { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Detail { get; set; }
    
        public virtual TypeDiscounts TypeDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
