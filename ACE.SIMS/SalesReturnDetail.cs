//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACE.SIMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesReturnDetail
    {
        public long SalesReturnDetailsID { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public long SalesReturnID { get; set; }
        public long ProductID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SalesReturn SalesReturn { get; set; }
    }
}
