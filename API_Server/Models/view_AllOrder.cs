//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Server.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_AllOrder
    {
        public Nullable<int> id { get; set; }
        public Nullable<int> id_Accounts { get; set; }
        public string Fullname { get; set; }
        public Nullable<double> Sum { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public Nullable<int> Status { get; set; }
        public string Address_District { get; set; }
        public string Address_Province { get; set; }
        public string AddressDetail { get; set; }
        public Nullable<int> Count { get; set; }
        public string Payment { get; set; }
        public Nullable<double> Ship_fee { get; set; }
        public Nullable<int> id_Shop { get; set; }
        public Nullable<double> Value___ { get; set; }
        public Nullable<double> Value___1 { get; set; }
        public string Code_Discounts { get; set; }
    }
}
