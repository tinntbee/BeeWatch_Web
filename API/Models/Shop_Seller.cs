//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Seller
    {
        public int id_Shop { get; set; }
        public int id_Seller { get; set; }
        public bool IsCheck { get; set; }
        public bool IsLock { get; set; }
    
        public virtual Sellers Sellers { get; set; }
        public virtual Shops Shops { get; set; }
    }
}