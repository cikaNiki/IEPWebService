//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iepDucan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public long Id { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<long> StatusId { get; set; }
        public Nullable<long> TypeId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual OrderStatu OrderStatu { get; set; }
        public virtual OrderType OrderType { get; set; }
    }
}
