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
    
    public partial class Shops
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shops()
        {
            this.Hot_Trend = new HashSet<Hot_Trend>();
            this.Orders = new HashSet<Orders>();
            this.Shop_Seller = new HashSet<Shop_Seller>();
            this.Watches = new HashSet<Watches>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> id_Master { get; set; }
        public string Address { get; set; }
        public Nullable<double> Point { get; set; }
        public Nullable<bool> Status { get; set; }
        public string UrlAvatar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hot_Trend> Hot_Trend { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Sellers Sellers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Seller> Shop_Seller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Watches> Watches { get; set; }
    }
}
